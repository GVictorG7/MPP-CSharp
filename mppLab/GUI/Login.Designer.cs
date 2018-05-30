namespace mppLab {
	partial class Form1 {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.components = new System.ComponentModel.Container();
			this.label1 = new System.Windows.Forms.Label();
			this.tbUser = new System.Windows.Forms.TextBox();
			this.Password = new System.Windows.Forms.Label();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.tbPass = new System.Windows.Forms.TextBox();
			this.buttonLogin = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(222, 84);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(57, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "UserName";
			// 
			// tbUser
			// 
			this.tbUser.Location = new System.Drawing.Point(225, 114);
			this.tbUser.Name = "tbUser";
			this.tbUser.Size = new System.Drawing.Size(100, 20);
			this.tbUser.TabIndex = 1;
			// 
			// Password
			// 
			this.Password.AutoSize = true;
			this.Password.Location = new System.Drawing.Point(225, 154);
			this.Password.Name = "Password";
			this.Password.Size = new System.Drawing.Size(53, 13);
			this.Password.TabIndex = 2;
			this.Password.Text = "Password";
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
			// 
			// tbPass
			// 
			this.tbPass.Location = new System.Drawing.Point(228, 187);
			this.tbPass.Name = "tbPass";
			this.tbPass.Size = new System.Drawing.Size(100, 20);
			this.tbPass.TabIndex = 4;
			// 
			// buttonLogin
			// 
			this.buttonLogin.Location = new System.Drawing.Point(225, 240);
			this.buttonLogin.Name = "buttonLogin";
			this.buttonLogin.Size = new System.Drawing.Size(75, 23);
			this.buttonLogin.TabIndex = 5;
			this.buttonLogin.Text = "Login";
			this.buttonLogin.UseVisualStyleBackColor = true;
			this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(535, 322);
			this.Controls.Add(this.buttonLogin);
			this.Controls.Add(this.tbPass);
			this.Controls.Add(this.Password);
			this.Controls.Add(this.tbUser);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox tbUser;
		private System.Windows.Forms.Label Password;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.TextBox tbPass;
		private System.Windows.Forms.Button buttonLogin;
	}
}

