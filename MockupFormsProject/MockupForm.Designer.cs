namespace MockupFormsProject
{
    partial class MockupForm
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
            displayTextBox = new TextBox();
            inputTextBox = new TextBox();
            applyButton = new Button();
            fetchButton = new Button();
            doSomethingButton = new Button();
            resetButton = new Button();
            SuspendLayout();
            // 
            // displayTextBox
            // 
            displayTextBox.Location = new Point(12, 12);
            displayTextBox.Name = "displayTextBox";
            displayTextBox.ReadOnly = true;
            displayTextBox.Size = new Size(344, 23);
            displayTextBox.TabIndex = 0;
            // 
            // inputTextBox
            // 
            inputTextBox.Location = new Point(12, 41);
            inputTextBox.Name = "inputTextBox";
            inputTextBox.Size = new Size(344, 23);
            inputTextBox.TabIndex = 1;
            // 
            // applyButton
            // 
            applyButton.Location = new Point(281, 70);
            applyButton.Name = "applyButton";
            applyButton.Size = new Size(75, 23);
            applyButton.TabIndex = 2;
            applyButton.Text = "Apply";
            applyButton.UseVisualStyleBackColor = true;
            applyButton.Click += applyButton_Click;
            // 
            // fetchButton
            // 
            fetchButton.Location = new Point(200, 70);
            fetchButton.Name = "fetchButton";
            fetchButton.Size = new Size(75, 23);
            fetchButton.TabIndex = 3;
            fetchButton.Text = "Fetch";
            fetchButton.UseVisualStyleBackColor = true;
            fetchButton.Click += fetchButton_Click;
            // 
            // doSomethingButton
            // 
            doSomethingButton.Location = new Point(200, 125);
            doSomethingButton.Name = "doSomethingButton";
            doSomethingButton.Size = new Size(156, 23);
            doSomethingButton.TabIndex = 4;
            doSomethingButton.Text = "Do something";
            doSomethingButton.UseVisualStyleBackColor = true;
            doSomethingButton.Click += doSomethingButton_Click;
            // 
            // resetButton
            // 
            resetButton.Location = new Point(12, 125);
            resetButton.Name = "resetButton";
            resetButton.Size = new Size(75, 23);
            resetButton.TabIndex = 5;
            resetButton.Text = "Reset";
            resetButton.UseVisualStyleBackColor = true;
            resetButton.Click += resetButton_Click;
            // 
            // MockupForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(368, 164);
            Controls.Add(resetButton);
            Controls.Add(doSomethingButton);
            Controls.Add(fetchButton);
            Controls.Add(applyButton);
            Controls.Add(inputTextBox);
            Controls.Add(displayTextBox);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "MockupForm";
            Text = "Mockup Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox displayTextBox;
        private TextBox inputTextBox;
        private Button applyButton;
        private Button fetchButton;
        private Button doSomethingButton;
        private Button resetButton;
    }
}