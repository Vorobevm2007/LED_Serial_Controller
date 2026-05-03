namespace SerialControllerLed
{
    partial class Screen
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            comboBoxPorts = new ComboBox();
            buttonConnect = new Button();
            buttonOffBlue = new Button();
            buttonOnBlue = new Button();
            buttonOffRed = new Button();
            buttonOnRed = new Button();
            buttonReset = new Button();
            SuspendLayout();
            // 
            // comboBoxPorts
            // 
            comboBoxPorts.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxPorts.FormattingEnabled = true;
            comboBoxPorts.Location = new Point(667, 12);
            comboBoxPorts.Name = "comboBoxPorts";
            comboBoxPorts.Size = new Size(121, 23);
            comboBoxPorts.TabIndex = 1;
            // 
            // buttonConnect
            // 
            buttonConnect.Cursor = Cursors.Hand;
            buttonConnect.Location = new Point(667, 41);
            buttonConnect.Name = "buttonConnect";
            buttonConnect.Size = new Size(121, 23);
            buttonConnect.TabIndex = 2;
            buttonConnect.Text = "Подключиться";
            buttonConnect.UseVisualStyleBackColor = true;
            buttonConnect.Click += buttonConnect_Click;
            // 
            // buttonOffBlue
            // 
            buttonOffBlue.Cursor = Cursors.Hand;
            buttonOffBlue.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonOffBlue.Location = new Point(403, 253);
            buttonOffBlue.Name = "buttonOffBlue";
            buttonOffBlue.Size = new Size(135, 128);
            buttonOffBlue.TabIndex = 9;
            buttonOffBlue.Text = "OFF Blue";
            buttonOffBlue.UseVisualStyleBackColor = true;
            buttonOffBlue.Click += buttonOffBlue_Click;
            // 
            // buttonOnBlue
            // 
            buttonOnBlue.Cursor = Cursors.Hand;
            buttonOnBlue.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonOnBlue.Location = new Point(262, 253);
            buttonOnBlue.Name = "buttonOnBlue";
            buttonOnBlue.Size = new Size(135, 128);
            buttonOnBlue.TabIndex = 8;
            buttonOnBlue.Text = "ON Blue";
            buttonOnBlue.UseVisualStyleBackColor = true;
            buttonOnBlue.Click += buttonOnBlue_Click;
            // 
            // buttonOffRed
            // 
            buttonOffRed.Cursor = Cursors.Hand;
            buttonOffRed.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonOffRed.Location = new Point(403, 71);
            buttonOffRed.Name = "buttonOffRed";
            buttonOffRed.Size = new Size(135, 128);
            buttonOffRed.TabIndex = 7;
            buttonOffRed.Text = "OFF Red";
            buttonOffRed.UseVisualStyleBackColor = true;
            buttonOffRed.Click += buttonOffRed_Click;
            // 
            // buttonOnRed
            // 
            buttonOnRed.Cursor = Cursors.Hand;
            buttonOnRed.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonOnRed.Location = new Point(262, 71);
            buttonOnRed.Name = "buttonOnRed";
            buttonOnRed.Size = new Size(135, 128);
            buttonOnRed.TabIndex = 6;
            buttonOnRed.Text = "ON Red";
            buttonOnRed.UseVisualStyleBackColor = true;
            buttonOnRed.Click += buttonOnRed_Click;
            // 
            // buttonReset
            // 
            buttonReset.Location = new Point(586, 12);
            buttonReset.Name = "buttonReset";
            buttonReset.Size = new Size(75, 23);
            buttonReset.TabIndex = 10;
            buttonReset.Text = "Обновить";
            buttonReset.UseVisualStyleBackColor = true;
            buttonReset.Click += buttonReset_Click;
            // 
            // Screen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonReset);
            Controls.Add(buttonOffBlue);
            Controls.Add(buttonOnBlue);
            Controls.Add(buttonOffRed);
            Controls.Add(buttonOnRed);
            Controls.Add(buttonConnect);
            Controls.Add(comboBoxPorts);
            Name = "Screen";
            Text = "Управление лампочками на ардуино(8 и 12 пины)";
            Load += Screen_Load;
            ResumeLayout(false);
        }

        #endregion

        private ComboBox comboBoxPorts;
        private Button buttonConnect;
        private Button buttonOffBlue;
        private Button buttonOnBlue;
        private Button buttonOffRed;
        private Button buttonOnRed;
        private Button buttonReset;
    }
}
