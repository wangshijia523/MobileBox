using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobileBox
{
    public sealed partial class FormRemote : Form
    {
        public FormRemote()
        {
            Dock = DockStyle.Fill;
            TopLevel = false;
            FormBorderStyle = FormBorderStyle.None;
            InitializeComponent();
        }

        private FormCopy _formcopy;
        private FormUploa _formuploa;
        private FormSwitch _formSwitch;
        private FormDel _formDel;


        private void copyButton_ButtonClick(object Sender)
        {
            if (_formcopy == null || _formcopy.IsDisposed)
            {
                _formcopy = new FormCopy();
                _formcopy.Show();
            }
            else
            {
                _formcopy.Activate(); //之前已打开，则给予焦点，置顶。
            }
        }

        private void uploaButton_ButtonClick(object Sender)
        {
            if (_formuploa == null || _formuploa.IsDisposed)
            {
                _formuploa = new FormUploa();
                _formuploa.Show();
            }
            else
            {
                _formuploa.Activate(); //之前已打开，则给予焦点，置顶。
            }
        }

        private void switchButton_ButtonClick(object Sender)
        {
            if (_formSwitch == null || _formSwitch.IsDisposed)
            {
                _formSwitch = new FormSwitch();
                _formSwitch.Show();
            }
            else
            {
                _formSwitch.Activate(); //之前已打开，则给予焦点，置顶。
            }
        }

        private void FormRemote_MouseMove(object sender, MouseEventArgs e)
        {
            Activate();
        }

        private void delButton_ButtonClick(object Sender)
        {
            if (_formDel == null || _formDel.IsDisposed)
            {
                _formDel = new FormDel();
                _formDel.Show();
            }
            else
            {
                _formDel.Activate(); //之前已打开，则给予焦点，置顶。
            }
        }
    }
}
