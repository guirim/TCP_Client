namespace TCPClient
{
    partial class Client
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다.
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_Full = new System.Windows.Forms.RichTextBox();
            this.txt_message = new System.Windows.Forms.TextBox();
            this.btn_start = new System.Windows.Forms.Button();
            this.txt_serverIP = new System.Windows.Forms.TextBox();
            this.txt_port = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Send = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_Full
            // 
            this.txt_Full.Location = new System.Drawing.Point(16, 47);
            this.txt_Full.Name = "txt_Full";
            this.txt_Full.Size = new System.Drawing.Size(580, 290);
            this.txt_Full.TabIndex = 0;
            this.txt_Full.Text = "";
            // 
            // txt_message
            // 
            this.txt_message.Location = new System.Drawing.Point(16, 361);
            this.txt_message.Name = "txt_message";
            this.txt_message.Size = new System.Drawing.Size(403, 21);
            this.txt_message.TabIndex = 1;
           // this.txt_message.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_message_KeyDown);
            // 
            // btn_start
            // 
            this.btn_start.Font = new System.Drawing.Font("한컴 소망 M", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_start.Location = new System.Drawing.Point(15, 10);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(136, 31);
            this.btn_start.TabIndex = 2;
            this.btn_start.Text = "Connect";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // txt_serverIP
            // 
            this.txt_serverIP.Location = new System.Drawing.Point(255, 12);
            this.txt_serverIP.Name = "txt_serverIP";
            this.txt_serverIP.Size = new System.Drawing.Size(105, 21);
            this.txt_serverIP.TabIndex = 3;
            this.txt_serverIP.Text = "127.0.0.1";
            // 
            // txt_port
            // 
            this.txt_port.Location = new System.Drawing.Point(405, 12);
            this.txt_port.Name = "txt_port";
            this.txt_port.Size = new System.Drawing.Size(126, 21);
            this.txt_port.TabIndex = 4;
            this.txt_port.Text = "9600";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(194, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "Server IP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(375, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "Port";
            // 
            // btn_Send
            // 
            this.btn_Send.Location = new System.Drawing.Point(444, 361);
            this.btn_Send.Name = "btn_Send";
            this.btn_Send.Size = new System.Drawing.Size(75, 23);
            this.btn_Send.TabIndex = 7;
            this.btn_Send.Text = "전송";
            this.btn_Send.UseVisualStyleBackColor = true;
            this.btn_Send.Click += new System.EventHandler(this.btn_Send_Click);
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 410);
            this.Controls.Add(this.btn_Send);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_port);
            this.Controls.Add(this.txt_serverIP);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.txt_message);
            this.Controls.Add(this.txt_Full);
            this.Name = "Client";
            this.Text = "Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txt_Full;
        private System.Windows.Forms.TextBox txt_message;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.TextBox txt_serverIP;
        private System.Windows.Forms.TextBox txt_port;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Send;
    }
}

