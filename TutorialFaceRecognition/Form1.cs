using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FaceRecognition;
namespace TutorialFaceRecognition
{
	public partial class Form1 : Form
	{

		FaceRec faceRec = new FaceRec();
		public Form1()
		{
			InitializeComponent();
	
		}

		private void btnOpenCamera_Click(object sender, EventArgs e)
		{
			faceRec.openCamera(pbCamera, pbCaptured);
		}

		private void btnSaveImage_Click(object sender, EventArgs e)
		{
			faceRec.Save_IMAGE(txtName.Text.ToUpper());
			MessageBox.Show("Save.");
		}

		private void btnDetectFaces_Click(object sender, EventArgs e)
		{
			faceRec.isTrained = true;
		}
	}
}
