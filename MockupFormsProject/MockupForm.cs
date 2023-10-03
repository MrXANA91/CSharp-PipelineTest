using MockupLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MockupFormsProject
{
    public partial class MockupForm : Form
    {
        MockupClass mockup;

        public MockupForm()
        {
            InitializeComponent();

            mockup = new MockupClass();
            UpdateDisplayText();
        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            mockup.GreetingMessage = this.inputTextBox.Text;
            UpdateDisplayText();
        }

        private void fetchButton_Click(object sender, EventArgs e)
        {
            UpdateInputText(mockup.ToString());
        }

        private void doSomethingButton_Click(object sender, EventArgs e)
        {
            mockup.DoSomething();
            UpdateDisplayText();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            mockup = new MockupClass();
            UpdateDisplayText();
            UpdateInputText("");
        }

        private void UpdateDisplayText()
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action(() =>
                {
                    UpdateDisplayText();
                }));
            }
            else
            {
                this.displayTextBox.Text = mockup.ToString();
            }
        }

        private void UpdateInputText(string text)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action(() =>
                {
                    UpdateInputText(text);
                }));
            }
            else
            {
                this.inputTextBox.Text = text;
            }
        }
    }
}
