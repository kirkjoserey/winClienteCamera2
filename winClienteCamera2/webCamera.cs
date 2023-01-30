using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winClienteCamera2
{
	public partial class webCamera : Form
	{
		private Camera cam;
		public webCamera()
		{
			InitializeComponent();
			cam = new Camera();

			bSubscribe.Visible = false;
			bGetMsg.Visible = false;

		}

		private void bClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private async void bSubscribe_Click(object sender, EventArgs e)
		{
			// Set cursor as hourglass
			Cursor.Current = Cursors.WaitCursor;
			picPlate.Visible = false;
			//POST
			string auxi = await cam.RunSetSubscribe();
			if (auxi != null)
			{
				lblPlate.Visible = false;
				rtGetMessages.Visible = false;
				rtResponse.Text = auxi;
				rtResponse.Visible = true;

				if (cam.strSetSubscribe != null)
				{
					lblServer.Text = cam.strSetSubscribe;


					var dt = new DateTime(1970, 1, 1, 0, 0, 0, 0).AddSeconds(Int32.Parse(cam.strCurrentTime)).ToLocalTime();
					lblCurr.Text = cam.strCurrentTime + " - " + dt.ToString();

					//dt = new DateTime(1970, 1, 1, 0, 0, 0, 0).AddSeconds(Int32.Parse(cam.strTerminationTime)).ToLocalTime();
					//lblTerm.Text = cam.strTerminationTime + " - " + dt.ToString();

				}

			}
			btShow.Visible = false;
			btHide.Visible = false;

			// Set cursor as default arrow
			Cursor.Current = Cursors.Default;
		}

		private async void bGetMsg_Click(object sender, EventArgs e)
		{
			// Set cursor as hourglass
			Cursor.Current = Cursors.WaitCursor;
			picPlate.Visible = false;
			//POST
			string auxi = await cam.RunGetMessages();
			if (auxi != null)
			{
				lblPlate.Visible= true;
				rtResponse.Visible = false;
				lblCurr.Visible = false;
				//lblTerm.Visible= false;
				lblServer.Visible = false;

				rtGetMessages.Text = auxi;

				if(cam.strPlateNumber!= null)
				{
					lblPlate.Text = "Dominio: " + cam.strPlateNumber;

					rtGetMessages.Visible = true;
					if (cam.strImage != "")
					{

						picPlate.Image = cam.getBitmapFromString(cam.strImage);
						btShow.Visible = true;
						btHide.Visible = true;

					}
				}

			}
			else
			{
				rtResponse.Visible = true;
				rtGetMessages.Text = auxi;
			}

			// Set cursor as default arrow
			Cursor.Current = Cursors.Default;
		}

		private void btShow_Click(object sender, EventArgs e)
		{
			picPlate.Visible = true;
		}

		private void btHide_Click(object sender, EventArgs e)
		{
			picPlate.Visible = false;
		}

		private void btSetClient_Click(object sender, EventArgs e)
		{
			cam.SetHttpClient();
			bSubscribe.Visible= true;
			bGetMsg.Visible= true;

		}
	}
}
