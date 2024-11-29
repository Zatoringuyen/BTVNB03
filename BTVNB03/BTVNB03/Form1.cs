using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BTVNB03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            ListViewItem lv = new ListViewItem(txt_LastName.Text);
            lv.SubItems.Add(txt_FirstName.Text);
            lv.SubItems.Add(txt_Phone.Text);
            listStudent.Items.Add(lv);
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (listStudent.SelectedItems.Count > 0) 
            {
                listStudent.Items.Remove(listStudent.SelectedItems[0]); 
                MessageBox.Show("Đã xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một mục để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (listStudent.SelectedItems.Count > 0) 
            {
                ListViewItem selectedItem = listStudent.SelectedItems[0];
                selectedItem.Text = txt_LastName.Text; 
                selectedItem.SubItems[1].Text = txt_FirstName.Text;
                selectedItem.SubItems[2].Text = txt_Phone.Text; 
                MessageBox.Show("Đã sửa thành công!", "Thông báo", MessageBoxButtons.OK,
                                                 MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một mục để sửa!", "Thông báo", MessageBoxButtons.OK,
                                                                            MessageBoxIcon.Warning);
            }
        }

        private void lvStudent_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listStudent.SelectedItems.Count > 0) 
            {
                ListViewItem selected = listStudent.SelectedItems[0];
                txt_LastName.Text = selected.Text; 
                txt_FirstName.Text = selected.SubItems[1].Text; 
                txt_Phone.Text = selected.SubItems[2].Text; 
            }
        }
    }
}




    

