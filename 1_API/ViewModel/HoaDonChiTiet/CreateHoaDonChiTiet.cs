﻿namespace _1_API.ViewModel.HoaDonChiTiet
{
    public class CreateHoaDonChiTiet
    {
        public Guid Id { get; set; }
        public Guid? IdSPChitiet { get; set; }
        public Guid? IdHoaDon { get; set; }
        public Guid? IdKichCo { get; set; }
        public int? SoLuong { get; set; }
        public decimal? GiaBan { get; set; }
    }
}
