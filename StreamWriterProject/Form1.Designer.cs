namespace StreamWriterProject
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
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnAttemdamce = new System.Windows.Forms.Button();
            this.btnDoneWithAttendance = new System.Windows.Forms.Button();
            this.btnWriteOrWriteLine = new System.Windows.Forms.Button();
            this.btnHelloWorld = new System.Windows.Forms.Button();
            this.btnNumberList = new System.Windows.Forms.Button();
            this.btnSaveFileDialog = new System.Windows.Forms.Button();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(39, 25);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(137, 18);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Enter your name:";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(184, 22);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(194, 30);
            this.txtName.TabIndex = 1;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnAttemdamce
            // 
            this.btnAttemdamce.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAttemdamce.Location = new System.Drawing.Point(23, 73);
            this.btnAttemdamce.Name = "btnAttemdamce";
            this.btnAttemdamce.Size = new System.Drawing.Size(189, 41);
            this.btnAttemdamce.TabIndex = 2;
            this.btnAttemdamce.Text = "Take Attendance";
            this.btnAttemdamce.UseVisualStyleBackColor = true;
            this.btnAttemdamce.Click += new System.EventHandler(this.btnAttemdamce_Click);
            // 
            // btnDoneWithAttendance
            // 
            this.btnDoneWithAttendance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoneWithAttendance.Location = new System.Drawing.Point(23, 134);
            this.btnDoneWithAttendance.Name = "btnDoneWithAttendance";
            this.btnDoneWithAttendance.Size = new System.Drawing.Size(189, 41);
            this.btnDoneWithAttendance.TabIndex = 3;
            this.btnDoneWithAttendance.Text = "Done with Attendance";
            this.btnDoneWithAttendance.UseVisualStyleBackColor = true;
            this.btnDoneWithAttendance.Click += new System.EventHandler(this.btnDoneWithAttendance_Click);
            // 
            // btnWriteOrWriteLine
            // 
            this.btnWriteOrWriteLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWriteOrWriteLine.Location = new System.Drawing.Point(23, 194);
            this.btnWriteOrWriteLine.Name = "btnWriteOrWriteLine";
            this.btnWriteOrWriteLine.Size = new System.Drawing.Size(189, 41);
            this.btnWriteOrWriteLine.TabIndex = 4;
            this.btnWriteOrWriteLine.Text = "Write Or WriteLine";
            this.btnWriteOrWriteLine.UseVisualStyleBackColor = true;
            // 
            // btnHelloWorld
            // 
            this.btnHelloWorld.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelloWorld.Location = new System.Drawing.Point(251, 73);
            this.btnHelloWorld.Name = "btnHelloWorld";
            this.btnHelloWorld.Size = new System.Drawing.Size(189, 41);
            this.btnHelloWorld.TabIndex = 5;
            this.btnHelloWorld.Text = "Hello World";
            this.btnHelloWorld.UseVisualStyleBackColor = true;
            this.btnHelloWorld.Click += new System.EventHandler(this.btnHelloWorld_Click);
            // 
            // btnNumberList
            // 
            this.btnNumberList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNumberList.Location = new System.Drawing.Point(251, 134);
            this.btnNumberList.Name = "btnNumberList";
            this.btnNumberList.Size = new System.Drawing.Size(189, 41);
            this.btnNumberList.TabIndex = 6;
            this.btnNumberList.Text = "Number List";
            this.btnNumberList.UseVisualStyleBackColor = true;
            // 
            // btnSaveFileDialog
            // 
            this.btnSaveFileDialog.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveFileDialog.Location = new System.Drawing.Point(251, 194);
            this.btnSaveFileDialog.Name = "btnSaveFileDialog";
            this.btnSaveFileDialog.Size = new System.Drawing.Size(189, 41);
            this.btnSaveFileDialog.TabIndex = 7;
            this.btnSaveFileDialog.Text = "Save File Dialog";
            this.btnSaveFileDialog.UseVisualStyleBackColor = true;
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(23, 256);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(417, 105);
            this.txtMessage.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 379);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.btnSaveFileDialog);
            this.Controls.Add(this.btnNumberList);
            this.Controls.Add(this.btnHelloWorld);
            this.Controls.Add(this.btnWriteOrWriteLine);
            this.Controls.Add(this.btnDoneWithAttendance);
            this.Controls.Add(this.btnAttemdamce);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnAttemdamce;
        private System.Windows.Forms.Button btnDoneWithAttendance;
        private System.Windows.Forms.Button btnWriteOrWriteLine;
        private System.Windows.Forms.Button btnHelloWorld;
        private System.Windows.Forms.Button btnNumberList;
        private System.Windows.Forms.Button btnSaveFileDialog;
        private System.Windows.Forms.TextBox txtMessage;
    }
}

