namespace Tyuiu.VorobevAD.Sprint6.Task0.V6
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            goida_button = new Button();
            goida_box = new TextBox();
            goida_label = new Label();
            goida_box2 = new TextBox();
            SuspendLayout();
            // 
            // goida_button
            // 
            goida_button.Location = new Point(727, 258);
            goida_button.Name = "goida_button";
            goida_button.Size = new Size(265, 29);
            goida_button.TabIndex = 0;
            goida_button.Text = "Прокнуть гойду";
            goida_button.UseVisualStyleBackColor = true;
            goida_button.Click += button1_Click;
            // 
            // goida_box
            // 
            goida_box.Location = new Point(211, 258);
            goida_box.Name = "goida_box";
            goida_box.Size = new Size(125, 27);
            goida_box.TabIndex = 1;
            goida_box.TextChanged += textBox1_TextChanged;
            // 
            // goida_label
            // 
            goida_label.AutoSize = true;
            goida_label.Location = new Point(75, 261);
            goida_label.Name = "goida_label";
            goida_label.Size = new Size(108, 20);
            goida_label.TabIndex = 2;
            goida_label.Text = "Введите гойду";
            goida_label.Click += label1_Click;
            // 
            // goida_box2
            // 
            goida_box2.Location = new Point(408, 259);
            goida_box2.Name = "goida_box2";
            goida_box2.Size = new Size(248, 27);
            goida_box2.TabIndex = 3;
            goida_box2.TextChanged += textBox2_TextChanged;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1087, 559);
            Controls.Add(goida_box2);
            Controls.Add(goida_label);
            Controls.Add(goida_box);
            Controls.Add(goida_button);
            Name = "MainForm";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        private Button goida_button;
        private TextBox goida_box;
        private Label goida_label;
        private TextBox goida_box2;
    }
}
