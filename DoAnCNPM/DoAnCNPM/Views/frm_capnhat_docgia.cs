using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAnCNPM.Controllers;
using DoAnCNPM.Shareds;
using DoAnCNPM.Models;

namespace DoAnCNPM.Views
{
    public partial class frm_capnhat_docgia : Form
    {
        // enum variable used for select option
        private Option option = Option.Nodata;

        private docgia_ctrl docgia_ctrl = new docgia_ctrl();

        // uses for save data from all textboxs
        private docgia_ett docgia_ett = new docgia_ett();


        // set value to caculate later on
        private void get_info()
        {
            if (txt_madocgia.Text != null && txt_madocgia.Text != "")
            {
                docgia_ett.madocgia = int.Parse(txt_madocgia.Text);
            }
            docgia_ett.tendocgia = txt_tendocgia.Text;
            docgia_ett.ngaysinh = txt_ngaysinh.Text;
            docgia_ett.lop = txt_lop.Text;
            docgia_ett.gioitinh = txt_gioitinh.Text;
            docgia_ett.diachi = txt_diachi.Text;
            docgia_ett.email = txt_email.Text;
        }

        //update data for dtgv
        private void load_data()
        {
            var dt = docgia_ctrl.select_all_docgia();
            switch (dt.errcode)
            {
                case Models.ErrorCode.NaN:
                    MessageBox.Show(dt.errInfor);
                    break;
                case Models.ErrorCode.sucess:
                    dtgv.DataSource = dt.data;
                    break;
                case Models.ErrorCode.fail:
                    if (Utils.switch_false())
                    {
                        MessageBox.Show(dt.errInfor);
                    }
                    break;
                default:
                    break;
            }
        }

        public frm_capnhat_docgia()
        {
            InitializeComponent();
            Utils.readOnly_text_box(new List<TextBox>{ txt_diachi, txt_email, txt_gioitinh, txt_lop, txt_ngaysinh, txt_tendocgia }, true);
        }

        

        private void frm_capnhat_docgia_Load(object sender, EventArgs e)
        {
            load_data();

            List<how_to_search> dt_source = new List<how_to_search>();
            dt_source.Add(new how_to_search("Họ tên", "hoten"));
            dt_source.Add(new how_to_search("Lớp", "lop"));
            dt_source.Add(new how_to_search("email", "email"));

            cbx_option_search.DataSource = dt_source;
            cbx_option_search.DisplayMember = "value";
            cbx_option_search.ValueMember = "key";
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            if (Utils.confirm_exit())
            {
                Application.Exit();
            }
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            Utils.erase_text_box(new List<TextBox> { txt_madocgia, txt_diachi, txt_email, txt_gioitinh, txt_lop, txt_ngaysinh, txt_tendocgia });
            Utils.readOnly_text_box(new List<TextBox> { txt_diachi, txt_email, txt_gioitinh, txt_lop, txt_ngaysinh, txt_tendocgia }, true);
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            Utils.erase_text_box(new List<TextBox> { txt_madocgia, txt_diachi, txt_email, txt_gioitinh, txt_lop, txt_ngaysinh, txt_tendocgia });
            Utils.readOnly_text_box(new List<TextBox> { txt_diachi, txt_email, txt_gioitinh, txt_lop, txt_ngaysinh, txt_tendocgia }, false);
            txt_tendocgia.Focus();
            option = Option.Insert;
        }

        private void dtgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >=0)
            {
                DataGridViewRow temp = dtgv.Rows[e.RowIndex];
                txt_madocgia.Text = temp.Cells[0].Value.ToString();
                txt_tendocgia.Text = temp.Cells[1].Value.ToString();
                txt_ngaysinh.Text = temp.Cells[2].Value.ToString();
                txt_gioitinh.Text = temp.Cells[3].Value.ToString();
                txt_lop.Text = temp.Cells[4].Value.ToString();
                txt_diachi.Text = temp.Cells[5].Value.ToString();
                txt_email.Text = temp.Cells[6].Value.ToString();
            }
        }

        private void txt_timkiem_TextChanged(object sender, EventArgs e)
        {
            var select_cbx = cbx_option_search.SelectedValue.ToString();
            var temp = docgia_ctrl.select_docgia_fields(txt_timkiem.Text, select_cbx);
            switch (temp.errcode)
            {
                case ErrorCode.NaN:
                    dtgv.DataSource = temp.data;
                    break;
                case ErrorCode.sucess:
                    dtgv.DataSource = temp.data;
                    break;
                case ErrorCode.fail:
                    dtgv.DataSource = temp.data;
                    if (Utils.switch_false())
                    {
                        MessageBox.Show(temp.errInfor);
                    }
                    break;
                default:
                    break;
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            option = Option.Edit;
            Utils.readOnly_text_box(new List<TextBox> { txt_diachi, txt_email, txt_gioitinh, txt_lop, txt_ngaysinh, txt_tendocgia }, false);

        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            switch (option)
            {
                case Option.Nodata:

                    break;

                case Option.Insert:
                    get_info();
                    //check if existing data
                    var check = true;
                    var data = dtgv.Rows;
                    foreach (DataGridViewRow item in data)
                    {
                        if (int.Parse(item.Cells[0].Value.ToString()) == docgia_ett.madocgia)
                        {
                            check = false;
                        }
                    }
                    if (!check)
                    {
                        Utils.err_duplicate_data();
                        break;
                    }
                    var temp = docgia_ctrl.insert_docgia(docgia_ett);
                    switch (temp.errcode)
                    {
                        case ErrorCode.NaN:
                            break;
                        case ErrorCode.sucess:
                            MessageBox.Show(Constants.success_insert);
                            load_data();
                            Utils.erase_text_box(new List<TextBox> { txt_madocgia, txt_diachi, txt_email, txt_gioitinh, txt_lop, txt_ngaysinh, txt_tendocgia });
                            break;
                        case ErrorCode.fail:
                            break;
                        default:
                            break;
                    }
                    break;

                case Option.Edit:
                    get_info();
                    //check if existing data
                    var check1 = true;
                    var data1 = dtgv.Rows;
                    foreach (DataGridViewRow item in data1)
                    {
                        if (int.Parse(item.Cells[0].Value.ToString()) == docgia_ett.madocgia)
                        {
                            check = false;
                        }
                    }
                    if (check1)
                    {
                        Utils.err_no_duplicate_data();
                        break;
                    }
                    var temp1 = docgia_ctrl.edit_docgia(docgia_ett);
                    switch (temp1.errcode)
                    {
                        case ErrorCode.NaN:
                            break;
                        case ErrorCode.sucess:
                            MessageBox.Show(Constants.success_insert);
                            load_data();
                            Utils.erase_text_box(new List<TextBox> { txt_madocgia, txt_diachi, txt_email, txt_gioitinh, txt_lop, txt_ngaysinh, txt_tendocgia });
                            Utils.readOnly_text_box(new List<TextBox> { txt_diachi, txt_email, txt_gioitinh, txt_lop, txt_ngaysinh, txt_tendocgia }, true);
                            break;
                        case ErrorCode.fail:
                            if (Utils.switch_false())
                            {
                                MessageBox.Show(temp1.errInfor);
                            }
                            break;
                        default:
                            break;
                    }
                    break;

                default:
                    break;
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            // get data user selected;
            var selected_r = dtgv.SelectedRows;
            if (selected_r.Count > 0)
            {
                if (Utils.confirm_delete())
                {
                    bool check = true;
                    string err_infor = "";
                    foreach (DataGridViewRow item in selected_r)
                    {
                        var temp = docgia_ctrl.delete_docgia(int.Parse(item.Cells[0].Value.ToString()));
                        switch (temp.errcode)
                        {
                            case ErrorCode.NaN:
                                break;
                            case ErrorCode.sucess:
                                Utils.erase_text_box(new List<TextBox> { txt_madocgia, txt_diachi, txt_email, txt_gioitinh, txt_lop, txt_ngaysinh, txt_tendocgia });
                                Utils.readOnly_text_box(new List<TextBox> { txt_diachi, txt_email, txt_gioitinh, txt_lop, txt_ngaysinh, txt_tendocgia }, true);
                                option = Option.Nodata;
                                break;
                            case ErrorCode.fail:
                                check = false;
                                err_infor = temp.errInfor;
                                break;
                            default:
                                break;
                        }
                    }

                    if (check)
                    {
                        MessageBox.Show(Constants.success_delete);
                        load_data();
                    }
                    else
                    {
                        MessageBox.Show(err_infor);
                    }
                }
            }
        }
    }
}
