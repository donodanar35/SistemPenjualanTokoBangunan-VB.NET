-- phpMyAdmin SQL Dump
-- version 4.8.3
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Waktu pembuatan: 06 Nov 2018 pada 14.15
-- Versi server: 10.1.36-MariaDB
-- Versi PHP: 5.6.38

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `tokoku`
--

-- --------------------------------------------------------

--
-- Struktur dari tabel `barang`
--

CREATE TABLE `barang` (
  `ID_BRG` char(20) NOT NULL,
  `ID_KAT` char(20) NOT NULL,
  `ID_SATUAN` char(20) NOT NULL,
  `NAMA_BRG` char(50) NOT NULL,
  `HARGA_JUAL` float NOT NULL,
  `HARGA_BELI` float NOT NULL,
  `PPN` float NOT NULL,
  `MIN_QTY` int(11) NOT NULL,
  `DISKON` float NOT NULL,
  `STOK` float NOT NULL,
  `SAMPEL` float NOT NULL,
  `MERK_BRG` char(30) DEFAULT NULL,
  `BOBOT_BRG` int(11) DEFAULT NULL,
  `KET_BRG` char(250) DEFAULT NULL,
  `STATUS` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `barang`
--

INSERT INTO `barang` (`ID_BRG`, `ID_KAT`, `ID_SATUAN`, `NAMA_BRG`, `HARGA_JUAL`, `HARGA_BELI`, `PPN`, `MIN_QTY`, `DISKON`, `STOK`, `SAMPEL`, `MERK_BRG`, `BOBOT_BRG`, `KET_BRG`, `STATUS`) VALUES
('brg1', 'kat1', 'sat3', 'Semen Gresik', 110000, 100000, 0.1, 5, 5, 228, 1, '', 40, '', 1),
('brg2', 'kat1', 'sat1', 'Batu Urug', 2100, 1000, 0, 0, 2, 1104, 1000, '1', 100, '', 1),
('brg3', 'kat1', 'sat1', 'Semen Padang', 12000, 10000, 0.1, 0, 9, 57, 1, '', 40, '', 1),
('brg4', 'kat1', 'sat3', 'semen tiga roda', 124000, 100000, 0.1, 0, 8, 108, 1, 'tiga roda', 40, '', 1),
('brg5', 'kat3', 'sat2', 'Diameter 8', 0, 0, 0.1, 0, 0, 100, 1, '', 0, '', 1);

-- --------------------------------------------------------

--
-- Struktur dari tabel `customer`
--

CREATE TABLE `customer` (
  `ID_CUS` char(20) NOT NULL,
  `NAMA_CUS` char(50) DEFAULT NULL,
  `ALAMAT_CUS` char(250) DEFAULT NULL,
  `EMAIL_CUS` char(50) DEFAULT NULL,
  `TELP_CUS` char(20) DEFAULT NULL,
  `JENIS_CUS` char(20) DEFAULT NULL,
  `KET_CUS` char(20) DEFAULT NULL,
  `STATUS` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `customer`
--

INSERT INTO `customer` (`ID_CUS`, `NAMA_CUS`, `ALAMAT_CUS`, `EMAIL_CUS`, `TELP_CUS`, `JENIS_CUS`, `KET_CUS`, `STATUS`) VALUES
('cus1', 'Sumber Kencono', '', '', '', 'retail', '', 1),
('cus2', 'Sumber Bagas', '', '', '', 'retail', '', 1);

-- --------------------------------------------------------

--
-- Struktur dari tabel `dbeli`
--

CREATE TABLE `dbeli` (
  `ID_BRG` char(20) NOT NULL,
  `ID_BELI` char(20) NOT NULL,
  `QTY_BELI` int(11) DEFAULT NULL,
  `HRG_BELI` int(11) DEFAULT NULL,
  `SUBTOTAL_BELI` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `dbeli`
--

INSERT INTO `dbeli` (`ID_BRG`, `ID_BELI`, `QTY_BELI`, `HRG_BELI`, `SUBTOTAL_BELI`) VALUES
('brg1', 'beli1', 100, 100000, 10000000),
('brg1', 'beli10', 10, 100000, 1000000),
('brg1', 'beli11', 9, 100000, 900000),
('brg1', 'beli12', 9, 100000, 900000),
('brg1', 'beli2', 100, 100000, 10000000),
('brg1', 'beli4', 2, 100000, 200000),
('brg1', 'beli5', 10, 100000, 1000000),
('brg1', 'beli6', 10, 100000, 1000000),
('brg1', 'beli7', 5, 100000, 500000),
('brg1', 'beli8', 10, 100000, 1000000),
('brg2', 'beli4', 2, 1000, 2000),
('brg2', 'beli7', 5, 1000, 5000),
('brg2', 'beli8', 10, 1000, 10000),
('brg3', 'beli4', 4, 10000, 40000),
('brg3', 'beli8', 10, 10000, 100000),
('brg4', 'beli8', 10, 100000, 1000000),
('brg5', 'beli8', 10, 0, 0);

-- --------------------------------------------------------

--
-- Struktur dari tabel `ddiskon`
--

CREATE TABLE `ddiskon` (
  `ID_BRG` char(20) NOT NULL,
  `ID_DISC` char(20) NOT NULL,
  `DISC_PERSEN` float DEFAULT NULL,
  `DISC_IDR` float NOT NULL,
  `MIN_QTY` int(11) NOT NULL,
  `HARGA_BELI` float NOT NULL,
  `HARGA_JUAL` float NOT NULL,
  `HARGA_DISKON` float NOT NULL,
  `PROFIT_PERBARANG` float NOT NULL,
  `PROFIT_PERTRANSAKSI` float NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `ddiskon`
--

INSERT INTO `ddiskon` (`ID_BRG`, `ID_DISC`, `DISC_PERSEN`, `DISC_IDR`, `MIN_QTY`, `HARGA_BELI`, `HARGA_JUAL`, `HARGA_DISKON`, `PROFIT_PERBARANG`, `PROFIT_PERTRANSAKSI`) VALUES
('brg1', 'diskon1', 5, 5500, 5, 100000, 110000, 104500, 4500, 22500),
('brg2', 'diskon2', 2, 42, 0, 1000, 2100, 2058, 1058, 0);

-- --------------------------------------------------------

--
-- Struktur dari tabel `djual`
--

CREATE TABLE `djual` (
  `ID_BRG` char(20) NOT NULL,
  `ID_JUAL` char(20) NOT NULL,
  `QTY_JUAL` int(11) DEFAULT NULL,
  `HRG_JUAL` int(11) DEFAULT NULL,
  `PPN` float DEFAULT NULL,
  `DISKON` float DEFAULT NULL,
  `SUBTOTAL_JUAL` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Struktur dari tabel `dsampel`
--

CREATE TABLE `dsampel` (
  `ID_SAM` char(20) NOT NULL,
  `ID_BRG` char(20) NOT NULL,
  `QTY_SAM` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `dsampel`
--

INSERT INTO `dsampel` (`ID_SAM`, `ID_BRG`, `QTY_SAM`) VALUES
('sam1', 'brg1', 1);

-- --------------------------------------------------------

--
-- Struktur dari tabel `dstockin`
--

CREATE TABLE `dstockin` (
  `ID_BRG` char(20) NOT NULL,
  `ID_STOCKIN` char(20) NOT NULL,
  `QTY` float DEFAULT NULL,
  `N_BAIK` float DEFAULT NULL,
  `N_RUSAK` float DEFAULT NULL,
  `HARGA_BELI` float DEFAULT NULL,
  `SUBTOTAL` float DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `dstockin`
--

INSERT INTO `dstockin` (`ID_BRG`, `ID_STOCKIN`, `QTY`, `N_BAIK`, `N_RUSAK`, `HARGA_BELI`, `SUBTOTAL`) VALUES
('brg1', 'stockin1', 9, 9, 0, 100000, 900000),
('brg1', 'stockin2', 9, 9, 0, 100000, 900000),
('brg3', 'stockin3', 7, 7, 0, 10000, 70000),
('brg4', 'stockin3', 8, 8, 0, 100000, 800000),
('brg1', 'stockin4', 2, 2, 0, 100000, 200000),
('brg1', 'stockin5', 8, 8, 0, 100000, 800000),
('brg1', 'stockin6', 9, 9, 0, 100000, 900000),
('brg1', 'stockin7', 8, 8, 0, 100000, 800000);

-- --------------------------------------------------------

--
-- Struktur dari tabel `dstockout`
--

CREATE TABLE `dstockout` (
  `ID_BRG` char(20) NOT NULL,
  `ID_STOCKOUT` char(20) NOT NULL,
  `QTY` float DEFAULT NULL,
  `N_BAIK` float DEFAULT NULL,
  `N_RUSAK` float DEFAULT NULL,
  `HARGA_BELI` float DEFAULT NULL,
  `SUBTOTAL` float DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `dstockout`
--

INSERT INTO `dstockout` (`ID_BRG`, `ID_STOCKOUT`, `QTY`, `N_BAIK`, `N_RUSAK`, `HARGA_BELI`, `SUBTOTAL`) VALUES
('brg1', 'stockout1', 9, 9, 0, 100000, 900000),
('brg1', 'stockout2', 7, 7, 0, 100000, 700000),
('brg1', 'stockout3', 8, 8, 0, 100000, 800000);

-- --------------------------------------------------------

--
-- Struktur dari tabel `hbeli`
--

CREATE TABLE `hbeli` (
  `ID_BELI` char(20) NOT NULL,
  `ID_KAR` char(20) NOT NULL,
  `ID_SUP` char(20) NOT NULL,
  `TGL_BELI` date DEFAULT NULL,
  `TGL_KIRIM` date NOT NULL,
  `TOTAL_ITEM` int(11) NOT NULL,
  `TOTAL` float DEFAULT NULL,
  `KET_BELI` char(250) DEFAULT NULL,
  `STATUS` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `hbeli`
--

INSERT INTO `hbeli` (`ID_BELI`, `ID_KAR`, `ID_SUP`, `TGL_BELI`, `TGL_KIRIM`, `TOTAL_ITEM`, `TOTAL`, `KET_BELI`, `STATUS`) VALUES
('beli1', 'kar2', 'sup1', '2018-11-03', '2018-11-03', 1, 10000000, '', 1),
('beli10', 'kar2', 'sup1', '2018-11-05', '2018-11-05', 1, 1000000, '', 1),
('beli11', 'kar2', 'sup1', '2018-11-05', '2018-11-05', 1, 900000, '', 1),
('beli12', 'kar1', 'sup1', '2018-11-05', '2018-11-05', 1, 900000, '', 1),
('beli2', 'kar2', 'sup1', '2018-11-04', '2018-11-04', 1, 10000000, '', 1),
('beli3', 'kar2', 'sup1', '2018-11-04', '2018-11-04', 1, 10000000, '', 1),
('beli4', 'kar2', 'sup1', '2018-11-04', '2018-11-04', 3, 242000, '', 1),
('beli5', 'kar2', 'sup1', '2018-11-05', '2018-11-05', 1, 1000000, '', 1),
('beli6', 'kar2', 'sup1', '2018-11-05', '2018-11-05', 1, 1000000, '', 1),
('beli7', 'kar2', 'sup1', '2018-11-05', '2018-11-05', 2, 505000, '', 1),
('beli8', 'kar2', 'sup1', '2018-11-05', '2018-11-05', 5, 2110000, '', 1),
('beli9', 'kar2', 'sup1', '2018-11-05', '2018-11-05', 0, 0, '', 1);

-- --------------------------------------------------------

--
-- Struktur dari tabel `hdiskon`
--

CREATE TABLE `hdiskon` (
  `ID_DISC` char(20) NOT NULL,
  `ID_KAR` char(20) NOT NULL,
  `PROMO` char(50) DEFAULT NULL,
  `TGL` date NOT NULL,
  `TGLAWAL_DISC` date DEFAULT NULL,
  `TGLAKHIR_DISC` date DEFAULT NULL,
  `KET_DISC` char(250) DEFAULT NULL,
  `STATUS_PROMO` enum('aktif','kadaluarsa','diproses') DEFAULT NULL,
  `STATUS` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `hdiskon`
--

INSERT INTO `hdiskon` (`ID_DISC`, `ID_KAR`, `PROMO`, `TGL`, `TGLAWAL_DISC`, `TGLAKHIR_DISC`, `KET_DISC`, `STATUS_PROMO`, `STATUS`) VALUES
('diskon1', 'kar2', 'spesial gresik', '2018-11-03', '2018-11-04', '2018-11-05', '', 'aktif', 2),
('diskon2', 'kar2', 'SPE', '2018-11-05', '2018-11-05', '2018-11-11', '', 'aktif', 2);

-- --------------------------------------------------------

--
-- Struktur dari tabel `hjual`
--

CREATE TABLE `hjual` (
  `ID_JUAL` char(20) NOT NULL,
  `ID_CUS` char(20) NOT NULL,
  `ID_SAM` char(20) NOT NULL,
  `ID_KAR` char(20) NOT NULL,
  `TGL_JUAL` date DEFAULT NULL,
  `TGL_KIRIM` date NOT NULL,
  `NAMA_PENERIMA` char(30) DEFAULT NULL,
  `ALAMAT_PENERIMA` char(50) DEFAULT NULL,
  `TELP_PENERIMA` char(20) DEFAULT NULL,
  `TOTAL_ITEM` int(11) NOT NULL,
  `TOTAL` float NOT NULL,
  `DIBAYAR` float DEFAULT NULL,
  `KEMBALI` float DEFAULT NULL,
  `TOTAL_PPN` float DEFAULT NULL,
  `TOTAL_DISKON` float DEFAULT NULL,
  `KET_JUAL` char(250) DEFAULT NULL,
  `STATUS` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `hjual`
--

INSERT INTO `hjual` (`ID_JUAL`, `ID_CUS`, `ID_SAM`, `ID_KAR`, `TGL_JUAL`, `TGL_KIRIM`, `NAMA_PENERIMA`, `ALAMAT_PENERIMA`, `TELP_PENERIMA`, `TOTAL_ITEM`, `TOTAL`, `DIBAYAR`, `KEMBALI`, `TOTAL_PPN`, `TOTAL_DISKON`, `KET_JUAL`, `STATUS`) VALUES
('jual1', 'cus1', 'sam1', 'kar3', '2018-11-05', '2018-11-05', '', '', '', 0, 0, 10, 10, 0, 0, '', 1);

-- --------------------------------------------------------

--
-- Struktur dari tabel `hsampel`
--

CREATE TABLE `hsampel` (
  `ID_SAM` char(20) NOT NULL,
  `ID_KAR` char(20) NOT NULL,
  `ID_CUS` char(20) NOT NULL,
  `TGL_SAM` date DEFAULT NULL,
  `TGL_KIRIM` date NOT NULL,
  `NAMA_PENERIMA` char(30) DEFAULT NULL,
  `ALAMAT_PENERIMA` char(50) DEFAULT NULL,
  `TELP_PENERIMA` char(20) DEFAULT NULL,
  `TOTAL_ITEM` int(11) NOT NULL,
  `TOTAL` float NOT NULL,
  `KET_SAM` char(250) DEFAULT NULL,
  `STATUS` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `hsampel`
--

INSERT INTO `hsampel` (`ID_SAM`, `ID_KAR`, `ID_CUS`, `TGL_SAM`, `TGL_KIRIM`, `NAMA_PENERIMA`, `ALAMAT_PENERIMA`, `TELP_PENERIMA`, `TOTAL_ITEM`, `TOTAL`, `KET_SAM`, `STATUS`) VALUES
('sam1', 'kar3', 'cus1', '2018-11-04', '2018-11-04', '', '', '', 1, 100000, '', 1);

-- --------------------------------------------------------

--
-- Struktur dari tabel `hstockin`
--

CREATE TABLE `hstockin` (
  `ID_STOCKIN` char(20) NOT NULL,
  `ID_KAR` char(20) NOT NULL,
  `TGL_PESAN` date NOT NULL,
  `TGL_KIRIM` date NOT NULL,
  `TGL_TERIMA` date NOT NULL,
  `REFERENSI` char(20) NOT NULL,
  `TOTAL` float NOT NULL,
  `TOTAL_ITEM` int(11) NOT NULL,
  `KETERANGAN` char(255) DEFAULT NULL,
  `STATUS_STOK` enum('diproses','selesai') NOT NULL,
  `STATUS` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `hstockin`
--

INSERT INTO `hstockin` (`ID_STOCKIN`, `ID_KAR`, `TGL_PESAN`, `TGL_KIRIM`, `TGL_TERIMA`, `REFERENSI`, `TOTAL`, `TOTAL_ITEM`, `KETERANGAN`, `STATUS_STOK`, `STATUS`) VALUES
('stockin1', 'kar1', '2018-11-05', '2018-11-05', '2018-11-05', '', 100000, 1, '', 'selesai', 1),
('stockin2', 'kar1', '2018-11-05', '2018-11-05', '2018-11-05', '', 100000, 1, '', 'selesai', 1),
('stockin3', 'kar1', '2018-11-05', '2018-11-05', '2018-11-05', '', 870000, 2, '', 'selesai', 1),
('stockin4', 'kar1', '2018-11-05', '2018-11-06', '2018-11-05', '', 200000, 1, '', 'diproses', 1),
('stockin5', 'kar1', '2018-11-05', '2018-11-05', '2018-11-05', '', 800000, 1, '', 'selesai', 1),
('stockin6', 'kar1', '2018-11-05', '2012-12-12', '2018-11-05', 'beli12', 900000, 1, '', 'selesai', 1),
('stockin7', 'kar1', '2018-11-05', '2018-11-07', '2018-11-05', '', 800000, 1, '', 'diproses', 1);

-- --------------------------------------------------------

--
-- Struktur dari tabel `hstockout`
--

CREATE TABLE `hstockout` (
  `ID_STOCKOUT` char(20) NOT NULL,
  `ID_KAR` char(20) NOT NULL,
  `TGL_PESAN` date NOT NULL,
  `TGL_KIRIM` date NOT NULL,
  `REFERENSI` char(20) NOT NULL,
  `TOTAL` float NOT NULL,
  `TOTAL_ITEM` int(11) NOT NULL,
  `KETERANGAN` char(255) DEFAULT NULL,
  `STATUS_STOK` enum('diproses','selesai') NOT NULL,
  `STATUS` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `hstockout`
--

INSERT INTO `hstockout` (`ID_STOCKOUT`, `ID_KAR`, `TGL_PESAN`, `TGL_KIRIM`, `REFERENSI`, `TOTAL`, `TOTAL_ITEM`, `KETERANGAN`, `STATUS_STOK`, `STATUS`) VALUES
('stockout1', 'kar1', '2018-11-05', '2018-11-05', '', 900000, 1, '', 'selesai', 1),
('stockout2', 'kar1', '2018-11-05', '2018-11-06', '', 700000, 1, '', 'selesai', 1),
('stockout3', 'kar1', '2018-11-05', '2018-11-05', '', 800000, 1, '', 'selesai', 1);

-- --------------------------------------------------------

--
-- Struktur dari tabel `karyawan`
--

CREATE TABLE `karyawan` (
  `ID_KAR` char(20) NOT NULL,
  `NAMA_KAR` char(30) DEFAULT NULL,
  `JABATAN` enum('manager','admin','kasir','staf gudang') DEFAULT NULL,
  `PASSWORD` char(100) DEFAULT NULL,
  `KET_KAR` char(250) DEFAULT NULL,
  `STATUS` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `karyawan`
--

INSERT INTO `karyawan` (`ID_KAR`, `NAMA_KAR`, `JABATAN`, `PASSWORD`, `KET_KAR`, `STATUS`) VALUES
('kar1', 'admin', 'admin', '21232f297a57a5a743894a0e4a801fc3', '', 1),
('kar2', 'manager', 'manager', '1d0258c2440a8d19e716292b231e3190', '', 1),
('kar3', 'kasir', 'kasir', 'c7911af3adbd12a035b289556d96470a', '', 1),
('kar4', 'staf gudang', 'staf gudang', '202446dd1d6028084426867365b0c7a1', '', 1),
('kar5', '', '', 'd41d8cd98f00b204e9800998ecf8427e', '', 0),
('kar6', 'staf gudang', '', '202446dd1d6028084426867365b0c7a1', '', 0);

-- --------------------------------------------------------

--
-- Struktur dari tabel `kategori`
--

CREATE TABLE `kategori` (
  `ID_KAT` char(20) NOT NULL,
  `NAMA_KAT` char(30) NOT NULL,
  `KET_KAT` char(250) DEFAULT NULL,
  `STATUS` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `kategori`
--

INSERT INTO `kategori` (`ID_KAT`, `NAMA_KAT`, `KET_KAT`, `STATUS`) VALUES
('kat1', 'Semen', '', 1),
('kat2', 'Batu', '', 1),
('kat3', 'besi', '', 1),
('kat4', 'pasir', '', 1),
('kat5', 'kayu', '', 1),
('kat6', 'tripleks', '', 1),
('kat7', 'wiremesh', '', 1),
('kat8', 'aspal', '', 1);

-- --------------------------------------------------------

--
-- Struktur dari tabel `satuan`
--

CREATE TABLE `satuan` (
  `ID_SATUAN` char(20) NOT NULL,
  `NAMA_SATUAN` char(30) NOT NULL,
  `KET_SATUAN` char(250) DEFAULT NULL,
  `STATUS` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `satuan`
--

INSERT INTO `satuan` (`ID_SATUAN`, `NAMA_SATUAN`, `KET_SATUAN`, `STATUS`) VALUES
('sat1', 'm3', '', 1),
('sat2', 'lonjor', '', 1),
('sat3', 'zak', '', 1),
('sat4', 'lembar', '', 1),
('sat5', 'drum', '', 1);

-- --------------------------------------------------------

--
-- Struktur dari tabel `supplier`
--

CREATE TABLE `supplier` (
  `ID_SUP` char(20) NOT NULL,
  `NAMA_SUP` char(50) DEFAULT NULL,
  `ALAMAT_SUP` char(250) DEFAULT NULL,
  `EMAIL_SUP` char(50) DEFAULT NULL,
  `TELP_SUP` char(20) DEFAULT NULL,
  `KET_SUP` char(250) DEFAULT NULL,
  `STATUS` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `supplier`
--

INSERT INTO `supplier` (`ID_SUP`, `NAMA_SUP`, `ALAMAT_SUP`, `EMAIL_SUP`, `TELP_SUP`, `KET_SUP`, `STATUS`) VALUES
('sup1', 'PT Harapan Jaya', 'Surabaya', 'sby@gmail.com', '12121221', '', 1),
('sup2', 'PT. Intan Jaya', 'KLT', NULL, NULL, NULL, 1),
('sup3', 'PT AndiPermata', NULL, NULL, NULL, NULL, 1);

--
-- Indexes for dumped tables
--

--
-- Indeks untuk tabel `barang`
--
ALTER TABLE `barang`
  ADD PRIMARY KEY (`ID_BRG`),
  ADD KEY `FK_DIKATEGORIKAN` (`ID_KAT`),
  ADD KEY `FK_MEMILIKI` (`ID_SATUAN`);

--
-- Indeks untuk tabel `customer`
--
ALTER TABLE `customer`
  ADD PRIMARY KEY (`ID_CUS`);

--
-- Indeks untuk tabel `dbeli`
--
ALTER TABLE `dbeli`
  ADD PRIMARY KEY (`ID_BRG`,`ID_BELI`),
  ADD KEY `FK_DBELI2` (`ID_BELI`);

--
-- Indeks untuk tabel `ddiskon`
--
ALTER TABLE `ddiskon`
  ADD PRIMARY KEY (`ID_BRG`,`ID_DISC`),
  ADD KEY `FK_DDISKON2` (`ID_DISC`);

--
-- Indeks untuk tabel `djual`
--
ALTER TABLE `djual`
  ADD PRIMARY KEY (`ID_BRG`,`ID_JUAL`),
  ADD KEY `FK_DJUAL2` (`ID_JUAL`);

--
-- Indeks untuk tabel `dsampel`
--
ALTER TABLE `dsampel`
  ADD PRIMARY KEY (`ID_SAM`,`ID_BRG`),
  ADD KEY `FK_DSAMPEL2` (`ID_BRG`);

--
-- Indeks untuk tabel `dstockin`
--
ALTER TABLE `dstockin`
  ADD PRIMARY KEY (`ID_STOCKIN`,`ID_BRG`),
  ADD KEY `ID_BRG` (`ID_BRG`);

--
-- Indeks untuk tabel `dstockout`
--
ALTER TABLE `dstockout`
  ADD PRIMARY KEY (`ID_STOCKOUT`,`ID_BRG`),
  ADD KEY `ID_BRG` (`ID_BRG`);

--
-- Indeks untuk tabel `hbeli`
--
ALTER TABLE `hbeli`
  ADD PRIMARY KEY (`ID_BELI`),
  ADD KEY `FK_MEMBELI` (`ID_KAR`),
  ADD KEY `FK_MENSUPPLY` (`ID_SUP`);

--
-- Indeks untuk tabel `hdiskon`
--
ALTER TABLE `hdiskon`
  ADD PRIMARY KEY (`ID_DISC`),
  ADD KEY `FK_MENDISKON` (`ID_KAR`);

--
-- Indeks untuk tabel `hjual`
--
ALTER TABLE `hjual`
  ADD PRIMARY KEY (`ID_JUAL`),
  ADD KEY `FK_MELAYANI_PENJUALAN` (`ID_KAR`),
  ADD KEY `FK_MEMBAYAR` (`ID_CUS`),
  ADD KEY `FK_TELAH_COBA` (`ID_SAM`);

--
-- Indeks untuk tabel `hsampel`
--
ALTER TABLE `hsampel`
  ADD PRIMARY KEY (`ID_SAM`),
  ADD KEY `FK_MENCOBA` (`ID_CUS`),
  ADD KEY `FK_MENGIRIM` (`ID_KAR`);

--
-- Indeks untuk tabel `hstockin`
--
ALTER TABLE `hstockin`
  ADD PRIMARY KEY (`ID_STOCKIN`),
  ADD KEY `ID_KAR` (`ID_KAR`);

--
-- Indeks untuk tabel `hstockout`
--
ALTER TABLE `hstockout`
  ADD PRIMARY KEY (`ID_STOCKOUT`),
  ADD KEY `ID_KAR` (`ID_KAR`);

--
-- Indeks untuk tabel `karyawan`
--
ALTER TABLE `karyawan`
  ADD PRIMARY KEY (`ID_KAR`);

--
-- Indeks untuk tabel `kategori`
--
ALTER TABLE `kategori`
  ADD PRIMARY KEY (`ID_KAT`);

--
-- Indeks untuk tabel `satuan`
--
ALTER TABLE `satuan`
  ADD PRIMARY KEY (`ID_SATUAN`);

--
-- Indeks untuk tabel `supplier`
--
ALTER TABLE `supplier`
  ADD PRIMARY KEY (`ID_SUP`);

--
-- Ketidakleluasaan untuk tabel pelimpahan (Dumped Tables)
--

--
-- Ketidakleluasaan untuk tabel `barang`
--
ALTER TABLE `barang`
  ADD CONSTRAINT `FK_DIKATEGORIKAN` FOREIGN KEY (`ID_KAT`) REFERENCES `kategori` (`ID_KAT`),
  ADD CONSTRAINT `FK_MEMILIKI` FOREIGN KEY (`ID_SATUAN`) REFERENCES `satuan` (`ID_SATUAN`);

--
-- Ketidakleluasaan untuk tabel `dbeli`
--
ALTER TABLE `dbeli`
  ADD CONSTRAINT `FK_DBELI` FOREIGN KEY (`ID_BRG`) REFERENCES `barang` (`ID_BRG`),
  ADD CONSTRAINT `FK_DBELI2` FOREIGN KEY (`ID_BELI`) REFERENCES `hbeli` (`ID_BELI`);

--
-- Ketidakleluasaan untuk tabel `ddiskon`
--
ALTER TABLE `ddiskon`
  ADD CONSTRAINT `FK_DDISKON` FOREIGN KEY (`ID_BRG`) REFERENCES `barang` (`ID_BRG`),
  ADD CONSTRAINT `FK_DDISKON2` FOREIGN KEY (`ID_DISC`) REFERENCES `hdiskon` (`ID_DISC`);

--
-- Ketidakleluasaan untuk tabel `djual`
--
ALTER TABLE `djual`
  ADD CONSTRAINT `FK_DJUAL` FOREIGN KEY (`ID_BRG`) REFERENCES `barang` (`ID_BRG`),
  ADD CONSTRAINT `FK_DJUAL2` FOREIGN KEY (`ID_JUAL`) REFERENCES `hjual` (`ID_JUAL`);

--
-- Ketidakleluasaan untuk tabel `dsampel`
--
ALTER TABLE `dsampel`
  ADD CONSTRAINT `FK_DSAMPEL` FOREIGN KEY (`ID_SAM`) REFERENCES `hsampel` (`ID_SAM`),
  ADD CONSTRAINT `FK_DSAMPEL2` FOREIGN KEY (`ID_BRG`) REFERENCES `barang` (`ID_BRG`);

--
-- Ketidakleluasaan untuk tabel `dstockin`
--
ALTER TABLE `dstockin`
  ADD CONSTRAINT `dstockin_ibfk_1` FOREIGN KEY (`ID_BRG`) REFERENCES `barang` (`ID_BRG`);

--
-- Ketidakleluasaan untuk tabel `dstockout`
--
ALTER TABLE `dstockout`
  ADD CONSTRAINT `dstockout_ibfk_1` FOREIGN KEY (`ID_BRG`) REFERENCES `barang` (`ID_BRG`);

--
-- Ketidakleluasaan untuk tabel `hbeli`
--
ALTER TABLE `hbeli`
  ADD CONSTRAINT `FK_MEMBELI` FOREIGN KEY (`ID_KAR`) REFERENCES `karyawan` (`ID_KAR`),
  ADD CONSTRAINT `FK_MENSUPPLY` FOREIGN KEY (`ID_SUP`) REFERENCES `supplier` (`ID_SUP`);

--
-- Ketidakleluasaan untuk tabel `hdiskon`
--
ALTER TABLE `hdiskon`
  ADD CONSTRAINT `FK_MENDISKON` FOREIGN KEY (`ID_KAR`) REFERENCES `karyawan` (`ID_KAR`);

--
-- Ketidakleluasaan untuk tabel `hjual`
--
ALTER TABLE `hjual`
  ADD CONSTRAINT `FK_MELAYANI_PENJUALAN` FOREIGN KEY (`ID_KAR`) REFERENCES `karyawan` (`ID_KAR`),
  ADD CONSTRAINT `FK_MEMBAYAR` FOREIGN KEY (`ID_CUS`) REFERENCES `customer` (`ID_CUS`),
  ADD CONSTRAINT `FK_TELAH_COBA` FOREIGN KEY (`ID_SAM`) REFERENCES `hsampel` (`ID_SAM`);

--
-- Ketidakleluasaan untuk tabel `hsampel`
--
ALTER TABLE `hsampel`
  ADD CONSTRAINT `FK_MENCOBA` FOREIGN KEY (`ID_CUS`) REFERENCES `customer` (`ID_CUS`),
  ADD CONSTRAINT `FK_MENGIRIM` FOREIGN KEY (`ID_KAR`) REFERENCES `karyawan` (`ID_KAR`);

--
-- Ketidakleluasaan untuk tabel `hstockin`
--
ALTER TABLE `hstockin`
  ADD CONSTRAINT `hstockin_ibfk_1` FOREIGN KEY (`ID_KAR`) REFERENCES `karyawan` (`ID_KAR`);

--
-- Ketidakleluasaan untuk tabel `hstockout`
--
ALTER TABLE `hstockout`
  ADD CONSTRAINT `hstockout_ibfk_1` FOREIGN KEY (`ID_KAR`) REFERENCES `karyawan` (`ID_KAR`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
