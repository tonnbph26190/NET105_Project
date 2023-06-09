using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _2_Data.Migrations
{
    public partial class oke : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ChucVu",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ten = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChucVu", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Hang",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TenHang = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hang", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "KhachHang",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ten = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MatKhau = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DiaChi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GioiTinh = table.Column<bool>(type: "bit", nullable: false),
                    Sdt = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NgaySinh = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KhachHang", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "KichCo",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Size = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KichCo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MaGiamGia",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ma = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NgayBatdau = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NgayKetthuc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SoLuong = table.Column<int>(type: "int", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false),
                    PhanTramGiam = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaGiamGia", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MauSac",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TenMau = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MauSac", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TheLoai",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TenTheLoai = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TheLoai", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NhanVien",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdCvu = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdGuiBaoCao = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Ten = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaNV = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MatKhau = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sdt = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AnhNhanVien = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GioiTinh = table.Column<bool>(type: "bit", nullable: false),
                    DiaChi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false),
                    NgaySinh = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdGuiBcNavigationId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NhanVien", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NhanVien_ChucVu_IdCvu",
                        column: x => x.IdCvu,
                        principalTable: "ChucVu",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_NhanVien_NhanVien_IdGuiBcNavigationId",
                        column: x => x.IdGuiBcNavigationId,
                        principalTable: "NhanVien",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "SanPham",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ten = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdHang = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SanPham", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SanPham_Hang_IdHang",
                        column: x => x.IdHang,
                        principalTable: "Hang",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GioHang",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdKH = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GioHang", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GioHang_KhachHang_IdKH",
                        column: x => x.IdKH,
                        principalTable: "KhachHang",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HoaDon",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdMaGiamGia = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdKH = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdNV = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    NgayTao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false),
                    TongTien = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DiaChi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaHD = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HoaDon", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HoaDon_KhachHang_IdKH",
                        column: x => x.IdKH,
                        principalTable: "KhachHang",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HoaDon_MaGiamGia_IdMaGiamGia",
                        column: x => x.IdMaGiamGia,
                        principalTable: "MaGiamGia",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_HoaDon_NhanVien_IdNV",
                        column: x => x.IdNV,
                        principalTable: "NhanVien",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "SanphamChitiet",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdSP = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdMauSac = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TenSPChiTiet = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaSPChiTiet = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AnhDaiDien = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AnhPhu1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AnhPhu2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AnhPhu3 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NgayTao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GiaNhap = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    GiaBan = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SanphamChitiet", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SanphamChitiet_MauSac_IdMauSac",
                        column: x => x.IdMauSac,
                        principalTable: "MauSac",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SanphamChitiet_SanPham_IdSP",
                        column: x => x.IdSP,
                        principalTable: "SanPham",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GiohangChitiet",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdSPChitiet = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdGioHang = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdKichCo = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    SoLuong = table.Column<int>(type: "int", nullable: false),
                    GiaBan = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GiohangChitiet", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GiohangChitiet_GioHang_IdGioHang",
                        column: x => x.IdGioHang,
                        principalTable: "GioHang",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GiohangChitiet_KichCo_IdKichCo",
                        column: x => x.IdKichCo,
                        principalTable: "KichCo",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_GiohangChitiet_SanphamChitiet_IdSPChitiet",
                        column: x => x.IdSPChitiet,
                        principalTable: "SanphamChitiet",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HinhAnh",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdChiTietSP = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LinkAnh = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HinhAnh", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HinhAnh_SanphamChitiet_IdChiTietSP",
                        column: x => x.IdChiTietSP,
                        principalTable: "SanphamChitiet",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HoadonChitiet",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdSPChitiet = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdHoaDon = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdKichCo = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    SoLuong = table.Column<int>(type: "int", nullable: false),
                    GiaBan = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HoadonChitiet", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HoadonChitiet_HoaDon_IdHoaDon",
                        column: x => x.IdHoaDon,
                        principalTable: "HoaDon",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HoadonChitiet_KichCo_IdKichCo",
                        column: x => x.IdKichCo,
                        principalTable: "KichCo",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_HoadonChitiet_SanphamChitiet_IdSPChitiet",
                        column: x => x.IdSPChitiet,
                        principalTable: "SanphamChitiet",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SizeSanPham",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdSanPhamChiTiet = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdSize = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SoLuong = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SizeSanPham", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SizeSanPham_KichCo_IdSize",
                        column: x => x.IdSize,
                        principalTable: "KichCo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SizeSanPham_SanphamChitiet_IdSanPhamChiTiet",
                        column: x => x.IdSanPhamChiTiet,
                        principalTable: "SanphamChitiet",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TheLoaiSanPham",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdTheLoai = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdChiTietSP = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TheLoaiSanPham", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TheLoaiSanPham_SanphamChitiet_IdChiTietSP",
                        column: x => x.IdChiTietSP,
                        principalTable: "SanphamChitiet",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TheLoaiSanPham_TheLoai_IdTheLoai",
                        column: x => x.IdTheLoai,
                        principalTable: "TheLoai",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Hang",
                columns: new[] { "Id", "TenHang" },
                values: new object[,]
                {
                    { new Guid("b9db8c0c-bf87-4e16-bdd2-a9fee4b14b4a"), "Adidas" },
                    { new Guid("da7a593f-20e5-407e-85c6-4bb0a97f1a73"), "Nike" }
                });

            migrationBuilder.InsertData(
                table: "KhachHang",
                columns: new[] { "Id", "DiaChi", "Email", "GioiTinh", "MatKhau", "NgaySinh", "Sdt", "Ten" },
                values: new object[,]
                {
                    { new Guid("3f8c0eff-a06a-4b07-a449-8832c622290d"), "1", "a", true, "1", new DateTime(2023, 6, 6, 12, 21, 8, 597, DateTimeKind.Local).AddTicks(6243), "1", "a" },
                    { new Guid("f572907f-4e58-4ee3-b282-8100a3a2043f"), "2", "b", true, "1", new DateTime(2023, 6, 6, 12, 21, 8, 597, DateTimeKind.Local).AddTicks(6249), "2", "b" }
                });

            migrationBuilder.InsertData(
                table: "KichCo",
                columns: new[] { "Id", "Size" },
                values: new object[,]
                {
                    { new Guid("2d53402b-696d-4e6e-b95e-fb5f2a99c014"), 41f },
                    { new Guid("3a218de7-0c55-4b70-a0d8-823195532b66"), 40f },
                    { new Guid("560cd8d3-52cc-4204-9145-0a142cdac1fd"), 42f },
                    { new Guid("9297a9b2-5c69-4b52-af99-57bbf137dcf1"), 39f },
                    { new Guid("9b9a3a86-196e-4fb2-9300-a64784962d59"), 43f },
                    { new Guid("cd27319d-468d-4189-99a4-b2da273492a3"), 36f },
                    { new Guid("d43ed236-c9cf-4659-ba0d-f834bb316d39"), 37f },
                    { new Guid("d6dc21e2-f1be-48ec-8f30-bd6bbc73daec"), 38f }
                });

            migrationBuilder.InsertData(
                table: "MauSac",
                columns: new[] { "Id", "TenMau" },
                values: new object[,]
                {
                    { new Guid("5e5f7d51-044f-4928-9aac-4a496c629231"), "Đỏ" },
                    { new Guid("7a6c0c50-fb67-44ea-9c62-ad0e0f67ab3c"), "Xanh" },
                    { new Guid("8d364a55-877f-45a5-9408-66afb8ab873f"), "Trắng" },
                    { new Guid("cfa013b0-34dc-44d5-a471-7c49a9ac167d"), "Đen" }
                });

            migrationBuilder.InsertData(
                table: "GioHang",
                columns: new[] { "Id", "IdKH" },
                values: new object[,]
                {
                    { new Guid("87c18de0-9653-408e-9f7d-36b2f5a3d890"), new Guid("f572907f-4e58-4ee3-b282-8100a3a2043f") },
                    { new Guid("9779e43b-fcfc-40a0-b778-fa6f4757fd55"), new Guid("3f8c0eff-a06a-4b07-a449-8832c622290d") }
                });

            migrationBuilder.InsertData(
                table: "SanPham",
                columns: new[] { "Id", "IdHang", "Ten", "TrangThai" },
                values: new object[,]
                {
                    { new Guid("01bf8a6c-d89a-4db2-9068-af277be488ae"), new Guid("b9db8c0c-bf87-4e16-bdd2-a9fee4b14b4a"), "Giay 1", 1 },
                    { new Guid("9a1b3786-d0d0-402a-bfd8-10db04f8e6ed"), new Guid("da7a593f-20e5-407e-85c6-4bb0a97f1a73"), "Giay 2", 1 }
                });

            migrationBuilder.InsertData(
                table: "SanphamChitiet",
                columns: new[] { "Id", "AnhDaiDien", "AnhPhu1", "AnhPhu2", "AnhPhu3", "GiaBan", "GiaNhap", "IdMauSac", "IdSP", "MaSPChiTiet", "NgayTao", "TenSPChiTiet", "TrangThai" },
                values: new object[,]
                {
                    { new Guid("51a13afd-08d1-4a20-a0e0-fb4447bd215d"), "null", "null", "null", "null", 200000m, 180000m, new Guid("5e5f7d51-044f-4928-9aac-4a496c629231"), new Guid("9a1b3786-d0d0-402a-bfd8-10db04f8e6ed"), "SP2", new DateTime(2023, 6, 6, 12, 21, 8, 597, DateTimeKind.Local).AddTicks(5799), "V2", 1 },
                    { new Guid("7aaf5675-683d-4608-9534-ea737a4247b3"), "null", "null", "null", "null", 100000m, 80000m, new Guid("7a6c0c50-fb67-44ea-9c62-ad0e0f67ab3c"), new Guid("01bf8a6c-d89a-4db2-9068-af277be488ae"), "SP1", new DateTime(2023, 6, 6, 12, 21, 8, 597, DateTimeKind.Local).AddTicks(5779), "V1", 1 },
                    { new Guid("bcb53bdb-2f7e-4026-a5a3-09ff834562ad"), "null", "null", "null", "null", 200000m, 180000m, new Guid("cfa013b0-34dc-44d5-a471-7c49a9ac167d"), new Guid("9a1b3786-d0d0-402a-bfd8-10db04f8e6ed"), "SP2", new DateTime(2023, 6, 6, 12, 21, 8, 597, DateTimeKind.Local).AddTicks(5811), "V2", 1 },
                    { new Guid("ec94662b-535d-4599-b462-9951c727be51"), "null", "null", "null", "null", 100000m, 80000m, new Guid("8d364a55-877f-45a5-9408-66afb8ab873f"), new Guid("01bf8a6c-d89a-4db2-9068-af277be488ae"), "SP1", new DateTime(2023, 6, 6, 12, 21, 8, 597, DateTimeKind.Local).AddTicks(5804), "V1", 1 }
                });

            migrationBuilder.InsertData(
                table: "HinhAnh",
                columns: new[] { "Id", "IdChiTietSP", "LinkAnh" },
                values: new object[,]
                {
                    { new Guid("b596d1db-4113-4ed7-99e2-fa96a945d23c"), new Guid("51a13afd-08d1-4a20-a0e0-fb4447bd215d"), "C:\\Users\\Admin\\source\\repos\\NET105_Project\\ProjectViews\\wwwroot\\AnhNhanVien\\5752c6ba-f2e2-4331-95f2-2abaad283f46_nature-3082832.jpg" },
                    { new Guid("e508ba75-5185-4ef4-b533-2099fff74a84"), new Guid("7aaf5675-683d-4608-9534-ea737a4247b3"), "C:\\Users\\Admin\\source\\repos\\NET105_Project\\ProjectViews\\wwwroot\\AnhNhanVien\\307ec916-d15c-41b9-aeb8-ebfbf7c58033_nature-3082832.jpg" }
                });

            migrationBuilder.InsertData(
                table: "SizeSanPham",
                columns: new[] { "Id", "IdSanPhamChiTiet", "IdSize", "SoLuong" },
                values: new object[,]
                {
                    { new Guid("0515437f-c4ab-4956-8b65-4f7d183b1620"), new Guid("7aaf5675-683d-4608-9534-ea737a4247b3"), new Guid("3a218de7-0c55-4b70-a0d8-823195532b66"), 10 },
                    { new Guid("06dd39cf-f6c7-4605-9d4a-b4f764c29c73"), new Guid("51a13afd-08d1-4a20-a0e0-fb4447bd215d"), new Guid("9297a9b2-5c69-4b52-af99-57bbf137dcf1"), 5 },
                    { new Guid("101c81ee-1ca5-4570-be45-c453527fa9aa"), new Guid("ec94662b-535d-4599-b462-9951c727be51"), new Guid("cd27319d-468d-4189-99a4-b2da273492a3"), 10 },
                    { new Guid("1030ea99-2996-4537-b301-3ff511199b66"), new Guid("ec94662b-535d-4599-b462-9951c727be51"), new Guid("560cd8d3-52cc-4204-9145-0a142cdac1fd"), 5 },
                    { new Guid("289ce400-38f1-47fc-a5fc-dbf88bf2582e"), new Guid("51a13afd-08d1-4a20-a0e0-fb4447bd215d"), new Guid("d43ed236-c9cf-4659-ba0d-f834bb316d39"), 5 },
                    { new Guid("4d38cd83-32ca-415b-8fbe-88b9a23489c5"), new Guid("bcb53bdb-2f7e-4026-a5a3-09ff834562ad"), new Guid("cd27319d-468d-4189-99a4-b2da273492a3"), 10 },
                    { new Guid("507812da-fb24-4429-b50f-c1f5c28d2cc5"), new Guid("ec94662b-535d-4599-b462-9951c727be51"), new Guid("d43ed236-c9cf-4659-ba0d-f834bb316d39"), 5 },
                    { new Guid("57987315-cc58-4f70-918f-23858dcea978"), new Guid("bcb53bdb-2f7e-4026-a5a3-09ff834562ad"), new Guid("3a218de7-0c55-4b70-a0d8-823195532b66"), 10 },
                    { new Guid("5885a945-5722-4177-8fa7-d26b0dacf980"), new Guid("7aaf5675-683d-4608-9534-ea737a4247b3"), new Guid("9297a9b2-5c69-4b52-af99-57bbf137dcf1"), 5 },
                    { new Guid("5ee0fa3d-9ab6-490a-83ca-01021103412d"), new Guid("7aaf5675-683d-4608-9534-ea737a4247b3"), new Guid("cd27319d-468d-4189-99a4-b2da273492a3"), 10 },
                    { new Guid("69d226ff-ad05-477f-8aaf-d4e9c8785233"), new Guid("ec94662b-535d-4599-b462-9951c727be51"), new Guid("d6dc21e2-f1be-48ec-8f30-bd6bbc73daec"), 5 },
                    { new Guid("69e6c908-ea91-4c4a-86f2-c5cb26ff9ee4"), new Guid("bcb53bdb-2f7e-4026-a5a3-09ff834562ad"), new Guid("9b9a3a86-196e-4fb2-9300-a64784962d59"), 5 },
                    { new Guid("6b5d160a-2812-4c8c-a63d-0a4535990221"), new Guid("7aaf5675-683d-4608-9534-ea737a4247b3"), new Guid("9b9a3a86-196e-4fb2-9300-a64784962d59"), 5 },
                    { new Guid("7378b6ec-8274-4186-8855-0cafc1ce5881"), new Guid("7aaf5675-683d-4608-9534-ea737a4247b3"), new Guid("d43ed236-c9cf-4659-ba0d-f834bb316d39"), 5 },
                    { new Guid("75c5f866-2e78-49bb-80bb-fcd9c7d662c8"), new Guid("51a13afd-08d1-4a20-a0e0-fb4447bd215d"), new Guid("2d53402b-696d-4e6e-b95e-fb5f2a99c014"), 5 },
                    { new Guid("801a3395-42b9-4874-8144-7d98bd15122e"), new Guid("bcb53bdb-2f7e-4026-a5a3-09ff834562ad"), new Guid("9297a9b2-5c69-4b52-af99-57bbf137dcf1"), 5 },
                    { new Guid("a16d0a3a-97e9-4b41-8c6a-54e35cdeaca3"), new Guid("51a13afd-08d1-4a20-a0e0-fb4447bd215d"), new Guid("d6dc21e2-f1be-48ec-8f30-bd6bbc73daec"), 5 },
                    { new Guid("a18febe6-0a68-44cb-8ca0-1514f5bb6d48"), new Guid("7aaf5675-683d-4608-9534-ea737a4247b3"), new Guid("560cd8d3-52cc-4204-9145-0a142cdac1fd"), 5 },
                    { new Guid("a8b2d347-1af2-4027-8c6c-f368e567675f"), new Guid("51a13afd-08d1-4a20-a0e0-fb4447bd215d"), new Guid("cd27319d-468d-4189-99a4-b2da273492a3"), 10 },
                    { new Guid("b172bc46-4292-4013-b327-6b2e3def9513"), new Guid("51a13afd-08d1-4a20-a0e0-fb4447bd215d"), new Guid("3a218de7-0c55-4b70-a0d8-823195532b66"), 10 },
                    { new Guid("bec142a2-48ab-4785-8295-63a08d7dbf99"), new Guid("7aaf5675-683d-4608-9534-ea737a4247b3"), new Guid("2d53402b-696d-4e6e-b95e-fb5f2a99c014"), 5 },
                    { new Guid("c5890b6f-463f-4ab3-9dba-cab55b32e929"), new Guid("ec94662b-535d-4599-b462-9951c727be51"), new Guid("9297a9b2-5c69-4b52-af99-57bbf137dcf1"), 5 },
                    { new Guid("d09fd8b7-8263-4014-91d8-63ea9470a8de"), new Guid("7aaf5675-683d-4608-9534-ea737a4247b3"), new Guid("d6dc21e2-f1be-48ec-8f30-bd6bbc73daec"), 5 },
                    { new Guid("daa1d08d-ec42-4db9-9c91-1ec72a7a7a09"), new Guid("ec94662b-535d-4599-b462-9951c727be51"), new Guid("2d53402b-696d-4e6e-b95e-fb5f2a99c014"), 5 },
                    { new Guid("df277b8d-c5d0-4f62-9df1-9b60a896f634"), new Guid("ec94662b-535d-4599-b462-9951c727be51"), new Guid("9b9a3a86-196e-4fb2-9300-a64784962d59"), 5 },
                    { new Guid("e0e5863b-7ae4-47d5-9a96-4c0f732af3f0"), new Guid("bcb53bdb-2f7e-4026-a5a3-09ff834562ad"), new Guid("2d53402b-696d-4e6e-b95e-fb5f2a99c014"), 5 },
                    { new Guid("e1cff87b-abd8-4bf0-a7ce-199bd2716fc0"), new Guid("bcb53bdb-2f7e-4026-a5a3-09ff834562ad"), new Guid("560cd8d3-52cc-4204-9145-0a142cdac1fd"), 5 },
                    { new Guid("ec43012e-0ca2-4379-bccf-abd59824b300"), new Guid("ec94662b-535d-4599-b462-9951c727be51"), new Guid("3a218de7-0c55-4b70-a0d8-823195532b66"), 10 },
                    { new Guid("efc5ffac-f3c6-4c13-a205-51cb97e7a99a"), new Guid("bcb53bdb-2f7e-4026-a5a3-09ff834562ad"), new Guid("d43ed236-c9cf-4659-ba0d-f834bb316d39"), 5 },
                    { new Guid("f10629ff-6d82-462d-9f28-a22ac96ff880"), new Guid("bcb53bdb-2f7e-4026-a5a3-09ff834562ad"), new Guid("d6dc21e2-f1be-48ec-8f30-bd6bbc73daec"), 5 },
                    { new Guid("fbad9b0b-0e5a-43a0-8fc9-6aebc586420c"), new Guid("51a13afd-08d1-4a20-a0e0-fb4447bd215d"), new Guid("560cd8d3-52cc-4204-9145-0a142cdac1fd"), 5 },
                    { new Guid("fe243159-e3d5-4e38-b4d5-875b908b1d73"), new Guid("51a13afd-08d1-4a20-a0e0-fb4447bd215d"), new Guid("9b9a3a86-196e-4fb2-9300-a64784962d59"), 5 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_GioHang_IdKH",
                table: "GioHang",
                column: "IdKH");

            migrationBuilder.CreateIndex(
                name: "IX_GiohangChitiet_IdGioHang",
                table: "GiohangChitiet",
                column: "IdGioHang");

            migrationBuilder.CreateIndex(
                name: "IX_GiohangChitiet_IdKichCo",
                table: "GiohangChitiet",
                column: "IdKichCo");

            migrationBuilder.CreateIndex(
                name: "IX_GiohangChitiet_IdSPChitiet",
                table: "GiohangChitiet",
                column: "IdSPChitiet");

            migrationBuilder.CreateIndex(
                name: "IX_HinhAnh_IdChiTietSP",
                table: "HinhAnh",
                column: "IdChiTietSP");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDon_IdKH",
                table: "HoaDon",
                column: "IdKH");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDon_IdMaGiamGia",
                table: "HoaDon",
                column: "IdMaGiamGia");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDon_IdNV",
                table: "HoaDon",
                column: "IdNV");

            migrationBuilder.CreateIndex(
                name: "IX_HoadonChitiet_IdHoaDon",
                table: "HoadonChitiet",
                column: "IdHoaDon");

            migrationBuilder.CreateIndex(
                name: "IX_HoadonChitiet_IdKichCo",
                table: "HoadonChitiet",
                column: "IdKichCo");

            migrationBuilder.CreateIndex(
                name: "IX_HoadonChitiet_IdSPChitiet",
                table: "HoadonChitiet",
                column: "IdSPChitiet");

            migrationBuilder.CreateIndex(
                name: "IX_NhanVien_IdCvu",
                table: "NhanVien",
                column: "IdCvu");

            migrationBuilder.CreateIndex(
                name: "IX_NhanVien_IdGuiBcNavigationId",
                table: "NhanVien",
                column: "IdGuiBcNavigationId");

            migrationBuilder.CreateIndex(
                name: "IX_SanPham_IdHang",
                table: "SanPham",
                column: "IdHang");

            migrationBuilder.CreateIndex(
                name: "IX_SanphamChitiet_IdMauSac",
                table: "SanphamChitiet",
                column: "IdMauSac");

            migrationBuilder.CreateIndex(
                name: "IX_SanphamChitiet_IdSP",
                table: "SanphamChitiet",
                column: "IdSP");

            migrationBuilder.CreateIndex(
                name: "IX_SizeSanPham_IdSanPhamChiTiet",
                table: "SizeSanPham",
                column: "IdSanPhamChiTiet");

            migrationBuilder.CreateIndex(
                name: "IX_SizeSanPham_IdSize",
                table: "SizeSanPham",
                column: "IdSize");

            migrationBuilder.CreateIndex(
                name: "IX_TheLoaiSanPham_IdChiTietSP",
                table: "TheLoaiSanPham",
                column: "IdChiTietSP");

            migrationBuilder.CreateIndex(
                name: "IX_TheLoaiSanPham_IdTheLoai",
                table: "TheLoaiSanPham",
                column: "IdTheLoai");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GiohangChitiet");

            migrationBuilder.DropTable(
                name: "HinhAnh");

            migrationBuilder.DropTable(
                name: "HoadonChitiet");

            migrationBuilder.DropTable(
                name: "SizeSanPham");

            migrationBuilder.DropTable(
                name: "TheLoaiSanPham");

            migrationBuilder.DropTable(
                name: "GioHang");

            migrationBuilder.DropTable(
                name: "HoaDon");

            migrationBuilder.DropTable(
                name: "KichCo");

            migrationBuilder.DropTable(
                name: "SanphamChitiet");

            migrationBuilder.DropTable(
                name: "TheLoai");

            migrationBuilder.DropTable(
                name: "KhachHang");

            migrationBuilder.DropTable(
                name: "MaGiamGia");

            migrationBuilder.DropTable(
                name: "NhanVien");

            migrationBuilder.DropTable(
                name: "MauSac");

            migrationBuilder.DropTable(
                name: "SanPham");

            migrationBuilder.DropTable(
                name: "ChucVu");

            migrationBuilder.DropTable(
                name: "Hang");
        }
    }
}
