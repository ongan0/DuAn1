﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using _1.DAL;

namespace _1.DAL.Migrations
{
    [DbContext(typeof(QLBHContext))]
    [Migration("20221122072919_DuAn1_QLBH")]
    partial class DuAn1_QLBH
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("_1.DAL.Models.ChiTietSanPham", b =>
                {
                    b.Property<Guid>("IdChiTietSp")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Anh")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("GiaBan")
                        .HasColumnType("real");

                    b.Property<float>("GiaNhap")
                        .HasColumnType("real");

                    b.Property<DateTime>("HanSD")
                        .HasColumnType("datetime")
                        .HasColumnName("HanSD");

                    b.Property<Guid>("IdDanhMuc")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdNhaPhanPhoi")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdSanPham")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("MaSp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("NgaySX")
                        .HasColumnType("datetime")
                        .HasColumnName("NgaySX");

                    b.Property<int>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("IdChiTietSp");

                    b.HasIndex("IdDanhMuc");

                    b.HasIndex("IdNhaPhanPhoi");

                    b.HasIndex("IdSanPham");

                    b.ToTable("ChiTietSanPham");
                });

            modelBuilder.Entity("_1.DAL.Models.ChucVu", b =>
                {
                    b.Property<Guid>("IdChucVu")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("MaCV")
                        .HasMaxLength(30)
                        .HasColumnType("varchar(30)")
                        .HasColumnName("MaCV");

                    b.Property<string>("TenCV")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("TenCV");

                    b.HasKey("IdChucVu");

                    b.ToTable("ChucVu");
                });

            modelBuilder.Entity("_1.DAL.Models.DanhMuc", b =>
                {
                    b.Property<Guid>("IdDanhMuc")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("MaDanhMuc")
                        .HasMaxLength(30)
                        .HasColumnType("varchar(30)")
                        .HasColumnName("MaDanhMuc");

                    b.Property<string>("TenDanhMuc")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("TenDanhMuc");

                    b.HasKey("IdDanhMuc");

                    b.ToTable("DanhMuc");
                });

            modelBuilder.Entity("_1.DAL.Models.GioHang", b =>
                {
                    b.Property<Guid>("IdGioHang")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdKhachHang")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdNhanVien")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("NgayTao")
                        .HasColumnType("datetime")
                        .HasColumnName("NgayTao");

                    b.Property<DateTime>("NgayThanhToan")
                        .HasColumnType("datetime")
                        .HasColumnName("NgayThanhToan");

                    b.HasKey("IdGioHang");

                    b.HasIndex("IdKhachHang");

                    b.ToTable("GioHang");
                });

            modelBuilder.Entity("_1.DAL.Models.GioHangChiTiet", b =>
                {
                    b.Property<Guid>("IdGioHang")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdChiTietSp")
                        .HasColumnType("uniqueidentifier");

                    b.Property<float>("DonGia")
                        .HasColumnType("real");

                    b.Property<int>("SoLuong")
                        .HasColumnType("int");

                    b.HasKey("IdGioHang", "IdChiTietSp");

                    b.HasIndex("IdChiTietSp");

                    b.ToTable("GioHangChiTiet");
                });

            modelBuilder.Entity("_1.DAL.Models.HoaDon", b =>
                {
                    b.Property<Guid>("IdHoaDon")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdKhachHang")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdKhuyenMai")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdNhanVien")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("MaHD")
                        .HasMaxLength(30)
                        .HasColumnType("varchar(30)")
                        .HasColumnName("MaHD");

                    b.Property<DateTime>("NgayTao")
                        .HasColumnType("datetime")
                        .HasColumnName("NgayTao");

                    b.Property<DateTime>("NgayThanhToan")
                        .HasColumnType("datetime")
                        .HasColumnName("NgayThanhToan");

                    b.Property<int>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("IdHoaDon");

                    b.HasIndex("IdKhachHang");

                    b.HasIndex("IdKhuyenMai");

                    b.HasIndex("IdNhanVien");

                    b.ToTable("HoaDon");
                });

            modelBuilder.Entity("_1.DAL.Models.HoaDonChiTiet", b =>
                {
                    b.Property<Guid>("IdHoaDon")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdChiTietSp")
                        .HasColumnType("uniqueidentifier");

                    b.Property<float>("GiaBan")
                        .HasColumnType("real");

                    b.Property<int>("SoLuong")
                        .HasColumnType("int");

                    b.Property<string>("TenSP")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("TenSP");

                    b.HasKey("IdHoaDon", "IdChiTietSp");

                    b.HasIndex("IdChiTietSp");

                    b.ToTable("HoaDonChiTiet");
                });

            modelBuilder.Entity("_1.DAL.Models.KhachHang", b =>
                {
                    b.Property<Guid>("IdKhachHang")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("DiaChi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MaKH")
                        .HasMaxLength(30)
                        .HasColumnType("varchar(30)")
                        .HasColumnName("MaKH");

                    b.Property<DateTime>("NgaySinh")
                        .HasColumnType("datetime")
                        .HasColumnName("NgaySinh");

                    b.Property<string>("SDT")
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)")
                        .HasColumnName("SDT");

                    b.Property<string>("TenKH")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("TenKH");

                    b.HasKey("IdKhachHang");

                    b.ToTable("KhachHang");
                });

            modelBuilder.Entity("_1.DAL.Models.KhuyenMai", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<float>("Giam")
                        .HasColumnType("real");

                    b.Property<string>("MaKM")
                        .HasMaxLength(30)
                        .HasColumnType("varchar(30)")
                        .HasColumnName("MaKM");

                    b.Property<int>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("KhuyenMai");
                });

            modelBuilder.Entity("_1.DAL.Models.NhaPhanPhoi", b =>
                {
                    b.Property<Guid>("IdNhaPhanPhoi")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("MaNhaPhanPhoi")
                        .HasMaxLength(30)
                        .HasColumnType("varchar(30)")
                        .HasColumnName("MaNhaPhanPhoi");

                    b.Property<string>("TenNhaPhanPhoi")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("TenNhaPhanPhoi");

                    b.HasKey("IdNhaPhanPhoi");

                    b.ToTable("NhaPhanPhoi");
                });

            modelBuilder.Entity("_1.DAL.Models.NhanVien", b =>
                {
                    b.Property<Guid>("IdNhanVien")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("DiaChi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("GioiTinh")
                        .HasColumnType("int");

                    b.Property<string>("Gmail")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("Gmail");

                    b.Property<Guid>("IdChucVu")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("MaNhanVien")
                        .HasMaxLength(30)
                        .HasColumnType("varchar(30)")
                        .HasColumnName("MaNhanVien");

                    b.Property<string>("MatKhau")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("MatKhau");

                    b.Property<DateTime>("NgaySinh")
                        .HasColumnType("datetime")
                        .HasColumnName("NgaySinh");

                    b.Property<string>("SDT")
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)")
                        .HasColumnName("SDT");

                    b.Property<string>("TenDangNhap")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("TenDangNhap");

                    b.Property<string>("TenNhanVien")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("TenNhanVien");

                    b.Property<bool>("TrangThai")
                        .HasColumnType("bit");

                    b.HasKey("IdNhanVien");

                    b.HasIndex("IdChucVu");

                    b.ToTable("NhanVien");
                });

            modelBuilder.Entity("_1.DAL.Models.SanPham", b =>
                {
                    b.Property<Guid>("IdSanPham")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("MaSP")
                        .HasMaxLength(30)
                        .HasColumnType("varchar(30)")
                        .HasColumnName("MaSP");

                    b.Property<string>("TenSP")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("TenSP");

                    b.HasKey("IdSanPham");

                    b.ToTable("SanPham");
                });

            modelBuilder.Entity("_1.DAL.Models.ChiTietSanPham", b =>
                {
                    b.HasOne("_1.DAL.Models.DanhMuc", "DanhMuc")
                        .WithMany("ChiTietSanPhams")
                        .HasForeignKey("IdDanhMuc")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("_1.DAL.Models.NhaPhanPhoi", "NhaPhanPhoi")
                        .WithMany("ChiTietSanPhams")
                        .HasForeignKey("IdNhaPhanPhoi")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("_1.DAL.Models.SanPham", "SanPham")
                        .WithMany("ChiTietSanPhams")
                        .HasForeignKey("IdSanPham")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DanhMuc");

                    b.Navigation("NhaPhanPhoi");

                    b.Navigation("SanPham");
                });

            modelBuilder.Entity("_1.DAL.Models.GioHang", b =>
                {
                    b.HasOne("_1.DAL.Models.KhachHang", "KhachHang")
                        .WithMany("GioHangs")
                        .HasForeignKey("IdKhachHang")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("KhachHang");
                });

            modelBuilder.Entity("_1.DAL.Models.GioHangChiTiet", b =>
                {
                    b.HasOne("_1.DAL.Models.ChiTietSanPham", "ChiTietSanPham")
                        .WithMany("GioHangChiTiets")
                        .HasForeignKey("IdChiTietSp")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("_1.DAL.Models.GioHang", "GioHang")
                        .WithMany("GioHangChiTiets")
                        .HasForeignKey("IdGioHang")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ChiTietSanPham");

                    b.Navigation("GioHang");
                });

            modelBuilder.Entity("_1.DAL.Models.HoaDon", b =>
                {
                    b.HasOne("_1.DAL.Models.KhachHang", "KhachHang")
                        .WithMany("HoaDons")
                        .HasForeignKey("IdKhachHang")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("_1.DAL.Models.KhuyenMai", "KhuyenMai")
                        .WithMany("HoaDons")
                        .HasForeignKey("IdKhuyenMai")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("_1.DAL.Models.NhanVien", "NhanVien")
                        .WithMany("HoaDons")
                        .HasForeignKey("IdNhanVien")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("KhachHang");

                    b.Navigation("KhuyenMai");

                    b.Navigation("NhanVien");
                });

            modelBuilder.Entity("_1.DAL.Models.HoaDonChiTiet", b =>
                {
                    b.HasOne("_1.DAL.Models.ChiTietSanPham", "ChiTietSanPham")
                        .WithMany("HoaDonChiTiets")
                        .HasForeignKey("IdChiTietSp")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("_1.DAL.Models.HoaDon", "HoaDon")
                        .WithMany("HoaDonChiTiets")
                        .HasForeignKey("IdHoaDon")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ChiTietSanPham");

                    b.Navigation("HoaDon");
                });

            modelBuilder.Entity("_1.DAL.Models.NhanVien", b =>
                {
                    b.HasOne("_1.DAL.Models.ChucVu", "ChucVu")
                        .WithMany("NhanViens")
                        .HasForeignKey("IdChucVu")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ChucVu");
                });

            modelBuilder.Entity("_1.DAL.Models.ChiTietSanPham", b =>
                {
                    b.Navigation("GioHangChiTiets");

                    b.Navigation("HoaDonChiTiets");
                });

            modelBuilder.Entity("_1.DAL.Models.ChucVu", b =>
                {
                    b.Navigation("NhanViens");
                });

            modelBuilder.Entity("_1.DAL.Models.DanhMuc", b =>
                {
                    b.Navigation("ChiTietSanPhams");
                });

            modelBuilder.Entity("_1.DAL.Models.GioHang", b =>
                {
                    b.Navigation("GioHangChiTiets");
                });

            modelBuilder.Entity("_1.DAL.Models.HoaDon", b =>
                {
                    b.Navigation("HoaDonChiTiets");
                });

            modelBuilder.Entity("_1.DAL.Models.KhachHang", b =>
                {
                    b.Navigation("GioHangs");

                    b.Navigation("HoaDons");
                });

            modelBuilder.Entity("_1.DAL.Models.KhuyenMai", b =>
                {
                    b.Navigation("HoaDons");
                });

            modelBuilder.Entity("_1.DAL.Models.NhaPhanPhoi", b =>
                {
                    b.Navigation("ChiTietSanPhams");
                });

            modelBuilder.Entity("_1.DAL.Models.NhanVien", b =>
                {
                    b.Navigation("HoaDons");
                });

            modelBuilder.Entity("_1.DAL.Models.SanPham", b =>
                {
                    b.Navigation("ChiTietSanPhams");
                });
#pragma warning restore 612, 618
        }
    }
}
