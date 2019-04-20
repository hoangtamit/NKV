namespace QuanLySanXuat.Object
{
    public partial class NhanVienObj
    {
        public string Manhanvien { get; set; }

        public string Tennhanvien { get; set; }

        public string Taikhoan { get; set; }

        public string Matkhau { get; set; }

        public string Ngaysinh { get; set; }

        public string Gioitinh { get; set; }

        public string Diachi { get; set; }

        public string Dienthoai { get; set; }

        public string Bophan { get; set; }

        public string Chucvu { get; set; }

        public string Tinhtrang { get; set; }

        public string Ghichu { get; set; }

        public string Giaodien { get; set; }

        public string Thongbao { get; set; }

        public NhanVienObj()
        {

        }

        public NhanVienObj(string _manhanvien, string _tennhanvien, string _taikhoan, string _matkhau, string _ngaysinh, string _gioitinh, string _diachi,
            string _dienthoai, string _bophan, string _chucvu, string _tinhtrang, string _ghichu ,string _giaodien, string _thongbao)
        {
            this.Manhanvien = _manhanvien;
            this.Tennhanvien = _tennhanvien;
            this.Taikhoan = _taikhoan;
            this.Matkhau = _matkhau;
            this.Ngaysinh = _ngaysinh;
            this.Gioitinh = _gioitinh;
            this.Diachi = _diachi;
            this.Dienthoai = _dienthoai;
            this.Bophan = _bophan;
            this.Chucvu = _chucvu;
            this.Tinhtrang = _tinhtrang;
            this.Ghichu = _ghichu;
            this.Giaodien = _giaodien;
            this.Thongbao = _thongbao;
        }
    }


}
