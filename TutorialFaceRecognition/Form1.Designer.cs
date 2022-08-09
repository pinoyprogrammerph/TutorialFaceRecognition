namespace TutorialFaceRecognition
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
			this.pbCamera = new System.Windows.Forms.PictureBox();
			this.pbCaptured = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtName = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.btnOpenCamera = new System.Windows.Forms.Button();
			this.btnSaveImage = new System.Windows.Forms.Button();
			this.btnDetectFaces = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbCamera)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbCaptured)).BeginInit();
			this.SuspendLayout();
			// 
			// fileSystemWatcher1
			// 
			this.fileSystemWatcher1.EnableRaisingEvents = true;
			this.fileSystemWatcher1.SynchronizingObject = this;
			// 
			// pbCamera
			// 
			this.pbCamera.Location = new System.Drawing.Point(12, 33);
			this.pbCamera.Name = "pbCamera";
			this.pbCamera.Size = new System.Drawing.Size(326, 222);
			this.pbCamera.TabIndex = 1;
			this.pbCamera.TabStop = false;
			// 
			// pbCaptured
			// 
			this.pbCaptured.Location = new System.Drawing.Point(12, 291);
			this.pbCaptured.Name = "pbCaptured";
			this.pbCaptured.Size = new System.Drawing.Size(326, 222);
			this.pbCaptured.TabIndex = 2;
			this.pbCaptured.TabStop = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 17);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(43, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "Camera";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 275);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(50, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "Captured";
			// 
			// txtName
			// 
			this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtName.Location = new System.Drawing.Point(125, 519);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(196, 24);
			this.txtName.TabIndex = 5;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(28, 526);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(35, 13);
			this.label3.TabIndex = 6;
			this.label3.Text = "Name";
			// 
			// btnOpenCamera
			// 
			this.btnOpenCamera.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnOpenCamera.Location = new System.Drawing.Point(367, 59);
			this.btnOpenCamera.Name = "btnOpenCamera";
			this.btnOpenCamera.Size = new System.Drawing.Size(215, 81);
			this.btnOpenCamera.TabIndex = 7;
			this.btnOpenCamera.Text = "Open Camera";
			this.btnOpenCamera.UseVisualStyleBackColor = true;
			this.btnOpenCamera.Click += new System.EventHandler(this.btnOpenCamera_Click);
			// 
			// btnSaveImage
			// 
			this.btnSaveImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSaveImage.Location = new System.Drawing.Point(367, 174);
			this.btnSaveImage.Name = "btnSaveImage";
			this.btnSaveImage.Size = new System.Drawing.Size(215, 81);
			this.btnSaveImage.TabIndex = 8;
			this.btnSaveImage.Text = "Save Image";
			this.btnSaveImage.UseVisualStyleBackColor = true;
			this.btnSaveImage.Click += new System.EventHandler(this.btnSaveImage_Click);
			// 
			// btnDetectFaces
			// 
			this.btnDetectFaces.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDetectFaces.Location = new System.Drawing.Point(367, 275);
			this.btnDetectFaces.Name = "btnDetectFaces";
			this.btnDetectFaces.Size = new System.Drawing.Size(215, 81);
			this.btnDetectFaces.TabIndex = 9;
			this.btnDetectFaces.Text = "Detect Faces";
			this.btnDetectFaces.UseVisualStyleBackColor = true;
			this.btnDetectFaces.Click += new System.EventHandler(this.btnDetectFaces_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 579);
			this.Controls.Add(this.btnDetectFaces);
			this.Controls.Add(this.btnSaveImage);
			this.Controls.Add(this.btnOpenCamera);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtName);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pbCaptured);
			this.Controls.Add(this.pbCamera);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbCamera)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbCaptured)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.IO.FileSystemWatcher fileSystemWatcher1;
		private System.Windows.Forms.Button btnSaveImage;
		private System.Windows.Forms.Button btnOpenCamera;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox pbCaptured;
		private System.Windows.Forms.PictureBox pbCamera;
		private System.Windows.Forms.Button btnDetectFaces;
	}
}

