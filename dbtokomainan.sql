-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Waktu pembuatan: 16 Bulan Mei 2025 pada 14.36
-- Versi server: 10.4.32-MariaDB
-- Versi PHP: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `dbtokomainan`
--

-- --------------------------------------------------------

--
-- Struktur dari tabel `mainan`
--

CREATE TABLE `mainan` (
  `id_mainan` int(11) NOT NULL,
  `nama_mainan` varchar(100) DEFAULT NULL,
  `kategori` varchar(50) DEFAULT NULL,
  `harga` decimal(10,2) DEFAULT NULL,
  `stok` int(11) DEFAULT NULL,
  `foto` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data untuk tabel `mainan`
--

INSERT INTO `mainan` (`id_mainan`, `nama_mainan`, `kategori`, `harga`, `stok`, `foto`) VALUES
(8, 'buzz', 'Action Figure', 120000.00, 6, 'buzz.jpg'),
(9, 'naruto', 'Game', 1200000.00, 1, 'naruto_figure.jpg');

-- --------------------------------------------------------

--
-- Struktur dari tabel `pelanggan`
--

CREATE TABLE `pelanggan` (
  `id_pelanggan` int(11) NOT NULL,
  `nama` varchar(100) DEFAULT NULL,
  `kata_sandi` varchar(20) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data untuk tabel `pelanggan`
--

INSERT INTO `pelanggan` (`id_pelanggan`, `nama`, `kata_sandi`) VALUES
(1, 'arif', '123'),
(2, 'Bagusigma', 'bagusbagus'),
(3, 'ace', '123'),
(5, 'rie', '123');

-- --------------------------------------------------------

--
-- Struktur dari tabel `transaksi`
--

CREATE TABLE `transaksi` (
  `id_transaksi` int(11) NOT NULL,
  `tanggal` date DEFAULT NULL,
  `total_harga` decimal(12,2) DEFAULT NULL,
  `id_pelanggan` int(11) DEFAULT NULL,
  `kuantitas` int(11) DEFAULT NULL,
  `nama_mainan` varchar(100) DEFAULT NULL,
  `status` enum('Unpaid','Cancelled','Paid') DEFAULT 'Unpaid'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data untuk tabel `transaksi`
--

INSERT INTO `transaksi` (`id_transaksi`, `tanggal`, `total_harga`, `id_pelanggan`, `kuantitas`, `nama_mainan`, `status`) VALUES
(15, '2025-05-16', 12000000.00, 1, 10, 'naruto', 'Cancelled'),
(16, '2025-05-16', 1200000.00, 3, 1, 'naruto', 'Cancelled'),
(17, '2025-05-16', 120000.00, 3, 1, 'buzz', 'Paid'),
(18, '2025-05-16', 13200000.00, 1, 11, 'naruto', 'Cancelled'),
(19, '2025-05-16', 1200000.00, 3, 1, 'naruto', 'Paid'),
(20, '2025-05-16', 1200000.00, 3, 1, 'naruto', 'Unpaid'),
(21, '2025-05-16', 9600000.00, 1, 8, 'naruto', 'Unpaid'),
(22, '2025-05-16', 240000.00, 1, 2, 'buzz', 'Unpaid'),
(23, '2025-05-16', 240000.00, 5, 2, 'buzz', 'Unpaid');

--
-- Indexes for dumped tables
--

--
-- Indeks untuk tabel `mainan`
--
ALTER TABLE `mainan`
  ADD PRIMARY KEY (`id_mainan`);

--
-- Indeks untuk tabel `pelanggan`
--
ALTER TABLE `pelanggan`
  ADD PRIMARY KEY (`id_pelanggan`);

--
-- Indeks untuk tabel `transaksi`
--
ALTER TABLE `transaksi`
  ADD PRIMARY KEY (`id_transaksi`),
  ADD KEY `id_pelanggan` (`id_pelanggan`);

--
-- AUTO_INCREMENT untuk tabel yang dibuang
--

--
-- AUTO_INCREMENT untuk tabel `mainan`
--
ALTER TABLE `mainan`
  MODIFY `id_mainan` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;

--
-- AUTO_INCREMENT untuk tabel `pelanggan`
--
ALTER TABLE `pelanggan`
  MODIFY `id_pelanggan` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT untuk tabel `transaksi`
--
ALTER TABLE `transaksi`
  MODIFY `id_transaksi` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=24;

--
-- Ketidakleluasaan untuk tabel pelimpahan (Dumped Tables)
--

--
-- Ketidakleluasaan untuk tabel `transaksi`
--
ALTER TABLE `transaksi`
  ADD CONSTRAINT `transaksi_ibfk_1` FOREIGN KEY (`id_pelanggan`) REFERENCES `pelanggan` (`id_pelanggan`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
