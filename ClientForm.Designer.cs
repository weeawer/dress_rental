namespace LR8
{
    partial class ClientForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dressesBox = new System.Windows.Forms.ComboBox();
            this.dressPicture = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rentsBox = new System.Windows.Forms.ComboBox();
            this.DopYslygiListBox = new System.Windows.Forms.CheckedListBox();
            this.previous = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.newRent = new System.Windows.Forms.Button();
            this.deleteClient = new System.Windows.Forms.Button();
            this.next = new System.Windows.Forms.Button();
            this.numLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cost = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.addCl = new System.Windows.Forms.TextBox();
            this.priceBox = new System.Windows.Forms.TextBox();
            this.depositBox = new System.Windows.Forms.TextBox();
            this.clientsBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dressPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(33, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "ФИО:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(33, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Платье:";
            // 
            // dressesBox
            // 
            this.dressesBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dressesBox.Location = new System.Drawing.Point(93, 141);
            this.dressesBox.Name = "dressesBox";
            this.dressesBox.Size = new System.Drawing.Size(307, 21);
            this.dressesBox.TabIndex = 3;
            this.dressesBox.SelectedIndexChanged += new System.EventHandler(this.dressesBox_SelectedIndexChanged);
            // 
            // dressPicture
            // 
            this.dressPicture.Location = new System.Drawing.Point(0, 0);
            this.dressPicture.Name = "dressPicture";
            this.dressPicture.Size = new System.Drawing.Size(100, 50);
            this.dressPicture.TabIndex = 28;
            this.dressPicture.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(33, 310);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Цена:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(33, 266);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Залог:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(33, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Дни аренды:";
            // 
            // rentsBox
            // 
            this.rentsBox.FormattingEnabled = true;
            this.rentsBox.Location = new System.Drawing.Point(119, 226);
            this.rentsBox.Name = "rentsBox";
            this.rentsBox.Size = new System.Drawing.Size(281, 21);
            this.rentsBox.TabIndex = 11;
            this.rentsBox.TextChanged += new System.EventHandler(this.Calculator);
            this.rentsBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.periodsBox_KeyPress);
            // 
            // DopYslygiListBox
            // 
            this.DopYslygiListBox.FormattingEnabled = true;
            this.DopYslygiListBox.Location = new System.Drawing.Point(433, 94);
            this.DopYslygiListBox.Name = "DopYslygiListBox";
            this.DopYslygiListBox.Size = new System.Drawing.Size(162, 169);
            this.DopYslygiListBox.TabIndex = 13;
            this.DopYslygiListBox.Click += new System.EventHandler(this.addServicesListBox_Click);
            this.DopYslygiListBox.SelectedIndexChanged += new System.EventHandler(this.Calculator);
            // 
            // previous
            // 
            this.previous.Location = new System.Drawing.Point(17, 397);
            this.previous.Name = "previous";
            this.previous.Size = new System.Drawing.Size(75, 33);
            this.previous.TabIndex = 14;
            this.previous.Text = "Назад";
            this.previous.UseVisualStyleBackColor = true;
            this.previous.Click += new System.EventHandler(this.previous_Click);
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveButton.Location = new System.Drawing.Point(133, 397);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(364, 33);
            this.saveButton.TabIndex = 16;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // newRent
            // 
            this.newRent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newRent.Location = new System.Drawing.Point(12, 12);
            this.newRent.Name = "newRent";
            this.newRent.Size = new System.Drawing.Size(276, 38);
            this.newRent.TabIndex = 17;
            this.newRent.Text = "Создать новую аренду";
            this.newRent.UseVisualStyleBackColor = true;
            this.newRent.Click += new System.EventHandler(this.newClient_Click);
            // 
            // deleteClient
            // 
            this.deleteClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteClient.Location = new System.Drawing.Point(294, 12);
            this.deleteClient.Name = "deleteClient";
            this.deleteClient.Size = new System.Drawing.Size(284, 38);
            this.deleteClient.TabIndex = 18;
            this.deleteClient.Text = "Удалить из базы";
            this.deleteClient.UseVisualStyleBackColor = true;
            this.deleteClient.Click += new System.EventHandler(this.deleteClient_Click);
            // 
            // next
            // 
            this.next.Location = new System.Drawing.Point(503, 397);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(75, 33);
            this.next.TabIndex = 19;
            this.next.Text = "Вперед";
            this.next.UseVisualStyleBackColor = true;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // numLabel
            // 
            this.numLabel.AutoSize = true;
            this.numLabel.Location = new System.Drawing.Point(186, 103);
            this.numLabel.Name = "numLabel";
            this.numLabel.Size = new System.Drawing.Size(0, 13);
            this.numLabel.TabIndex = 21;
            this.numLabel.UseWaitCursor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(320, 341);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 33);
            this.label7.TabIndex = 22;
            this.label7.Text = "Итог:";
            // 
            // cost
            // 
            this.cost.AutoSize = true;
            this.cost.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cost.Location = new System.Drawing.Point(429, 349);
            this.cost.Name = "cost";
            this.cost.Size = new System.Drawing.Size(88, 24);
            this.cost.TabIndex = 23;
            this.cost.Text = "0 рублей";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(33, 183);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 15);
            this.label8.TabIndex = 25;
            this.label8.Text = "Номер телефона:";
            // 
            // addCl
            // 
            this.addCl.Location = new System.Drawing.Point(151, 182);
            this.addCl.Name = "addCl";
            this.addCl.Size = new System.Drawing.Size(249, 20);
            this.addCl.TabIndex = 1;
            // 
            // priceBox
            // 
            this.priceBox.Location = new System.Drawing.Point(79, 309);
            this.priceBox.Name = "priceBox";
            this.priceBox.Size = new System.Drawing.Size(321, 20);
            this.priceBox.TabIndex = 26;
            this.priceBox.TextChanged += new System.EventHandler(this.Calculator);
            this.priceBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.priceBox_KeyPress);
            this.priceBox.Leave += new System.EventHandler(this.BoundPrice);
            // 
            // depositBox
            // 
            this.depositBox.Location = new System.Drawing.Point(83, 265);
            this.depositBox.Name = "depositBox";
            this.depositBox.Size = new System.Drawing.Size(317, 20);
            this.depositBox.TabIndex = 27;
            this.depositBox.TextChanged += new System.EventHandler(this.Calculator);
            this.depositBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.depositsBox_KeyPress);
            this.depositBox.Leave += new System.EventHandler(this.BoundDeposit);
            // 
            // clientsBox
            // 
            this.clientsBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.clientsBox.Location = new System.Drawing.Point(93, 100);
            this.clientsBox.Name = "clientsBox";
            this.clientsBox.Size = new System.Drawing.Size(307, 21);
            this.clientsBox.TabIndex = 3;
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 455);
            this.Controls.Add(this.depositBox);
            this.Controls.Add(this.priceBox);
            this.Controls.Add(this.addCl);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cost);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.numLabel);
            this.Controls.Add(this.next);
            this.Controls.Add(this.deleteClient);
            this.Controls.Add(this.newRent);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.previous);
            this.Controls.Add(this.DopYslygiListBox);
            this.Controls.Add(this.rentsBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dressPicture);
            this.Controls.Add(this.clientsBox);
            this.Controls.Add(this.dressesBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ClientForm";
            this.Text = "Аренда";
            this.Load += new System.EventHandler(this.ClientForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dressPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox dressPicture;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox rentsBox;
        private System.Windows.Forms.CheckedListBox DopYslygiListBox;
        private System.Windows.Forms.Button previous;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button newRent;
        private System.Windows.Forms.Button deleteClient;
        private System.Windows.Forms.Button next;
        private System.Windows.Forms.Label numLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label cost;
        private System.Windows.Forms.ComboBox dressesBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox addCl;
        private System.Windows.Forms.TextBox priceBox;
        private System.Windows.Forms.TextBox depositBox;
        private System.Windows.Forms.ComboBox clientsBox;
    }
}