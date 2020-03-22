-- phpMyAdmin SQL Dump
-- version 4.9.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Mar 22, 2020 at 12:00 PM
-- Server version: 10.4.10-MariaDB
-- PHP Version: 7.3.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `data`
--
DROP DATABASE IF EXISTS `data`;
CREATE DATABASE IF NOT EXISTS `data` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci;
USE `data`;

-- --------------------------------------------------------

--
-- Table structure for table `accountdata`
--

CREATE TABLE `accountdata` (
  `AD_EIN` int(11) NOT NULL,
  `AD_Username` varchar(50) NOT NULL,
  `AD_Password` varchar(50) NOT NULL,
  `AD_FullName` varchar(50) NOT NULL,
  `AD_Role` varchar(50) NOT NULL,
  `AD_CashierNumber` varchar(50) NOT NULL,
  `AD_Online` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `accountdata`
--

INSERT INTO `accountdata` (`AD_EIN`, `AD_Username`, `AD_Password`, `AD_FullName`, `AD_Role`, `AD_CashierNumber`, `AD_Online`) VALUES
(1, 'potpot', 'srwsrw', 'DanteProgio1', 'Admin', '', 'Offline'),
(5, 'dante', 'srwsrw', 'dante progio', 'Cashier', '1', 'Offline'),
(6, 'chris1', 'fkulv', 'Oppa Chris', 'Cashier', '2', 'Offline'),
(8, 'paul1', 'sdxo', 'paul luna ', 'Admin', '', 'Offline'),
(10, 'dante123', '456789:;<', 'danteprogio', 'Cashier', '8', 'Offline'),
(11, 'paul2', 'sdxo', 'Paul Placido', 'Cashier', '10', 'Offline'),
(12, 'dans', 'gdqv', 'dans', 'Cashier', '6', 'Offline'),
(13, 'dans1', '456789:;<3', 'dans1', 'Admin', '', 'Offline');

-- --------------------------------------------------------

--
-- Table structure for table `accountreport`
--

CREATE TABLE `accountreport` (
  `Date` varchar(50) NOT NULL,
  `CashierNo` varchar(50) NOT NULL,
  `CashierEIN` varchar(50) NOT NULL,
  `TotalSale` varchar(50) NOT NULL,
  `CSPayment` varchar(50) NOT NULL,
  `CSChange` varchar(50) NOT NULL,
  `ORNumber` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `accountreport`
--

INSERT INTO `accountreport` (`Date`, `CashierNo`, `CashierEIN`, `TotalSale`, `CSPayment`, `CSChange`, `ORNumber`) VALUES
('02/22/2020', '1', '5', '200', '200', '0', 1),
('02/22/2020', '1', '5', '120', '200', '80', 2),
('02/22/2020', '1', '5', '160', '400', '240', 3),
('02/22/2020', '1', '5', '160', '200', '40', 4),
('02/22/2020', '1', '5', '160', '400', '240', 5),
('02/22/2020', '1', '5', '240', '300', '60', 6),
('02/22/2020', '1', '5', '384', '400', '16', 7),
('02/22/2020', '1', '5', '200', '400', '200', 8),
('02/22/2020', '1', '5', '360', '400', '40', 9),
('02/22/2020', '1', '5', '160', '200', '40', 10),
('02/22/2020', '1', '5', '160', '200', '40', 11),
('02/22/2020', '1', '5', '120', '200', '80', 12),
('02/22/2020', '1', '5', '200', '200', '0', 13),
('02/22/2020', '1', '5', '400', '400', '0', 14),
('02/22/2020', '1', '5', '400', '400', '0', 15),
('02/22/2020', '1', '5', '280', '400', '120', 16),
('02/22/2020', '1', '5', '880', '1000', '120', 17),
('02/22/2020', '1', '5', '880', '1000', '120', 18),
('02/22/2020', '1', '5', '880', '1000', '120', 19),
('02/22/2020', '1', '5', '880', '1000', '120', 20),
('02/22/2020', '1', '5', '720', '1000', '280', 21),
('02/22/2020', '1', '5', '720', '1000', '280', 22),
('02/22/2020', '1', '5', '720', '1000', '280', 23),
('02/22/2020', '1', '5', '880', '1000', '120', 24),
('02/22/2020', '1', '5', '1000', '1000', '0', 25),
('02/22/2020', '1', '5', '880', '1000', '120', 26),
('02/22/2020', '1', '5', '408', '500', '92', 27),
('02/22/2020', '1', '5', '600', '600', '0', 28),
('02/22/2020', '1', '5', '7700', '8000', '300', 29),
('02/25/2020', '1', '5', '154', '300', '146', 30),
('02/25/2020', '1', '5', '154', '500', '346', 31),
('02/25/2020', '1', '5', '154', '600', '446', 32),
('02/25/2020', '1', '5', '154', '400', '246', 33),
('02/25/2020', '1', '5', '154', '200', '46', 34),
('02/25/2020', '1', '5', '154', '200', '46', 35),
('03/07/2020', '2', '6', '4', '20', '16', 36),
('03/07/2020', '10', '11', '6720', '65656565', '65649845', 37),
('03/07/2020', '10', '11', '123646', '5454545', '5330899', 38),
('03/08/2020', '1', '5', '8', '10', '2', 39),
('03/08/2020', '1', '5', '200', '200', '0', 40);

-- --------------------------------------------------------

--
-- Table structure for table `orfrom`
--

CREATE TABLE `orfrom` (
  `name` varchar(50) NOT NULL,
  `price` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `productdata`
--

CREATE TABLE `productdata` (
  `Date` varchar(50) NOT NULL,
  `ProductID` varchar(50) NOT NULL,
  `ProductName` varchar(50) NOT NULL,
  `Quantity` int(50) NOT NULL,
  `Price` int(50) NOT NULL,
  `ExpDate` varchar(50) NOT NULL,
  `category` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `productdata`
--

INSERT INTO `productdata` (`Date`, `ProductID`, `ProductName`, `Quantity`, `Price`, `ExpDate`, `category`) VALUES
('1-23-2020', '102', 'maxx red', 297, 4, '1-23-2021', 'Candys'),
('2-15-2020', '103', 'banana', 69, 150, '2-15-2020', 'Frozen Foods'),
('3-7-2020', '104', 'lollipop', 100, 5, '3-30-2020', 'Candys'),
('3-7-2020', '105', 'Rebisco', 223, 68, '5-22-2020', 'Bread/Bakert'),
('3-7-2020', '106', 'Hansel', 123, 80, '6-11-2020', 'Bread/Bakert'),
('3-7-2020', '107', 'Mentos', 150, 76, '8-6-2020', 'Candys'),
('3-7-2020', '108', 'Gatorade', 123, 283, '1-21-2021', 'Beverages'),
('3-7-2020', '109', 'Chubby', 100, 59, '5-14-2020', 'Bread/Bakert'),
('3-7-2020', '110', 'Champy', 120, 70, '6-5-2020', 'Candys'),
('3-7-2020', '111', 'kikyam', 160, 19, '8-19-2020', 'Frozen Foods'),
('3-7-2020', '112', 'Piatos', 125, 230, '8-20-2020', 'Snacks'),
('3-7-2020', '113', 'Nova', 125, 260, '8-14-2020', 'Snacks'),
('3-7-2020', '115', 'Zesto Choco', 235, 230, '10-13-2020', 'Beverages'),
('3-7-2020', '114', 'Zesto', 250, 250, '7-7-2021', 'Beverages'),
('3-7-2020', '116', 'Coca Cola', 260, 320, '7-29-2021', 'Beverages'),
('3-7-2020', '117', 'Emperador', 100, 860, '12-18-2024', 'Beverages'),
('3-7-2020', '118', 'Fundador', 100, 850, '10-27-2023', 'Beverages'),
('3-7-2020', '119', 'San Miglight', 120, 970, '9-11-2023', 'Beverages'),
('3-7-2020', '200', 'Manggo', 100, 70, '3-17-2020', 'Frozen Foods'),
('3-7-2020', '201', 'Orange', 118, 100, '3-26-2020', 'Frozen Foods'),
('3-7-2020', '202', 'Grapes', 100, 120, '3-26-2020', 'Frozen Foods'),
('3-7-2020', '203', 'C2', 250, 1650, '2-18-2021', 'Beverages'),
('3-7-2020', '204', 'MInitmade', 100, 1200, '10-9-2020', 'Beverages'),
('3-7-2020', '205', 'Smart C', 50, 23, '11-20-2020', 'Beverages'),
('3-7-2020', '206', 'Maxx Green', 100, 150, '3-29-2119', 'Candys'),
('3-7-2020', '207', 'Maxx Orange', 100, 150, '12-9-2020', 'Candys'),
('3-7-2020', '208', 'Maxx Blue', 100, 150, '9-3-2020', 'Candys'),
('3-7-2020', '209', 'Tang', 150, 263, '10-22-2020', 'Others'),
('3-7-2020', '210', 'Notebook', 250, 500, '12-25-2020', 'Others'),
('3-7-2020', '211', 'Ballpen', 999, 20, '1-5-2041', 'Others'),
('3-7-2020', '212', 'Pencil', 999, 20, '10-30-2100', 'Others'),
('3-7-2020', '213', 'Crayons', 999, 35, '12-31-2035', 'Others'),
('3-7-2020', '214', 'Condoms', 860, 50, '12-31-2110', 'Others'),
('3-7-2020', '215', 'Shmapoo', 460, 152, '7-30-2025', 'Personla Care'),
('3-7-2020', '216', 'Dishwashing Liquids', 500, 130, '6-23-2028', 'Others'),
('3-7-2020', '217', 'Tissue', 999, 100, '12-31-2110', 'Paper Goods'),
('3-7-2020', '218', 'Cloud 9', 252, 120, '7-14-2021', 'Candys'),
('3-7-2020', '219', 'Eggs', 200, 150, '7-23-2020', 'Frozen Foods'),
('3-7-2020', '220', 'Cooking Oil', 0, 211, '7-28-2022', 'Condiments/Spices'),
('3-10-2020', '221', 'Pepsi', 100, 590, '7-29-2021', 'Beverages'),
('3-10-2020', '222', 'Royal', 100, 600, '8-20-2021', 'Beverages'),
('3-10-2020', '223', 'Tattos', 150, 230, '12-18-2020', 'Snacks'),
('3-10-2020', '224', 'Chippi', 120, 250, '8-28-2020', 'Snacks'),
('3-10-2020', '225', 'Loaded', 200, 240, '11-27-2020', 'Snacks'),
('3-10-2020', '226', 'Pillows', 140, 210, '11-26-2020', 'Snacks'),
('3-10-2020', '227', 'Alibaba', 230, 230, '12-31-2020', 'Snacks'),
('3-10-2020', '228', 'Kiss', 200, 130, '11-12-2020', 'Others'),
('3-10-2020', '229', 'Bangus', 210, 230, '12-17-2020', 'Frozen Foods'),
('3-10-2020', '230', 'Sirena', 250, 130, '12-2-2020', 'Snacks'),
('3-10-2020', '231', 'Inasal', 110, 120, '8-14-2020', 'Snacks'),
('3-10-2020', '232', 'Tilapya', 110, 1200, '7-30-2020', 'Frozen Foods'),
('3-10-2020', '233', 'Hanny', 230, 140, '12-24-2020', 'Candys'),
('3-10-2020', '234', 'Mentos', 150, 250, '11-27-2020', 'Candys'),
('3-10-2020', '235', 'Roller Coster', 100, 10, '3-10-2021', 'Snacks'),
('3-10-2020', '236', 'Happy', 150, 120, '11-4-2020', 'Candys'),
('3-10-2020', '237', 'Hi-Ho', 100, 140, '1-7-2021', 'Snacks'),
('3-10-2020', '238', 'Red Horse', 150, 1200, '8-6-2025', 'Beverages'),
('3-10-2020', '239', 'Alfonso', 160, 1450, '8-6-2025', 'Beverages'),
('3-10-2020', '240', 'Silvers Swan', 150, 450, '7-21-2022', 'Condiments/Spices'),
('3-19-2020', '1000', '3 in one coffee', 100, 50, '3-19-2021', 'Beverages');

-- --------------------------------------------------------

--
-- Table structure for table `salerecord`
--

CREATE TABLE `salerecord` (
  `Date` varchar(50) NOT NULL,
  `EIN` varchar(50) NOT NULL,
  `CashierNumber` varchar(50) NOT NULL,
  `TotalSale` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `salerecord`
--

INSERT INTO `salerecord` (`Date`, `EIN`, `CashierNumber`, `TotalSale`) VALUES
('2-15-2020', '5', '1', 396),
('2-15-2020', '5', '1', 160),
('2-15-2020', '5', '1', 200),
('2-15-2020', '5', '1', 1260),
('2-15-2020', '5', '1', 76),
('2-15-2020', '5', '1', 51867242),
('2-17-2020', '5', '1', 800),
('2-17-2020', '5', '1', 2000),
('2-17-2020', '5', '1', 31200),
('2-17-2020', '5', '1', 6120),
('2-17-2020', '5', '1', 61600),
('2-17-2020', '6', '2', 75000),
('2-21-2020', '5', '1', 200),
('2-21-2020', '5', '1', 360),
('2-21-2020', '5', '1', 356),
('2-21-2020', '5', '1', 236),
('2-21-2020', '5', '1', 680),
('2-21-2020', '5', '1', 64),
('2-21-2020', '5', '1', 2196),
('2-21-2020', '5', '1', 200),
('2-22-2020', '5', '1', 75200),
('2-22-2020', '5', '1', 7700),
('2-22-2020', '5', '1', 7700),
('2-22-2020', '5', '1', 360),
('2-22-2020', '5', '1', 75200),
('2-22-2020', '5', '1', 400),
('2-22-2020', '5', '1', 400),
('2-22-2020', '5', '1', 200),
('2-22-2020', '5', '1', 2000),
('2-22-2020', '5', '1', 200),
('2-22-2020', '5', '1', 200),
('2-22-2020', '5', '1', 160),
('2-22-2020', '5', '1', 2000),
('2-22-2020', '5', '1', 360),
('2-22-2020', '5', '1', 2000),
('2-22-2020', '5', '1', 2000),
('2-22-2020', '5', '1', 200),
('2-22-2020', '5', '1', 200),
('2-22-2020', '5', '1', 120),
('2-22-2020', '5', '1', 160),
('2-22-2020', '5', '1', 160),
('2-22-2020', '5', '1', 160),
('2-22-2020', '5', '1', 240),
('2-22-2020', '5', '1', 384),
('2-22-2020', '5', '1', 200),
('2-22-2020', '5', '1', 360),
('2-22-2020', '5', '1', 160),
('2-22-2020', '5', '1', 160),
('2-22-2020', '5', '1', 120),
('2-22-2020', '5', '1', 200),
('2-22-2020', '5', '1', 400),
('2-22-2020', '5', '1', 400),
('2-22-2020', '5', '1', 280),
('2-22-2020', '5', '1', 880),
('2-22-2020', '5', '1', 880),
('2-22-2020', '5', '1', 880),
('2-22-2020', '5', '1', 880),
('2-22-2020', '5', '1', 720),
('2-22-2020', '5', '1', 720),
('2-22-2020', '5', '1', 720),
('2-22-2020', '5', '1', 880),
('2-22-2020', '5', '1', 1000),
('2-22-2020', '5', '1', 880),
('2-22-2020', '5', '1', 408),
('2-22-2020', '5', '1', 600),
('2-22-2020', '5', '1', 7700),
('2-25-2020', '5', '1', 154),
('2-25-2020', '5', '1', 154),
('2-25-2020', '5', '1', 154),
('2-25-2020', '5', '1', 154),
('2-25-2020', '5', '1', 154),
('2-25-2020', '5', '1', 154),
('3-7-2020', '6', '2', 4),
('3-7-2020', '11', '10', 6720),
('3-7-2020', '11', '10', 123646),
('3-8-2020', '5', '1', 8),
('3-8-2020', '5', '1', 200);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `accountdata`
--
ALTER TABLE `accountdata`
  ADD PRIMARY KEY (`AD_EIN`);

--
-- Indexes for table `accountreport`
--
ALTER TABLE `accountreport`
  ADD PRIMARY KEY (`ORNumber`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `accountdata`
--
ALTER TABLE `accountdata`
  MODIFY `AD_EIN` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=17;

--
-- AUTO_INCREMENT for table `accountreport`
--
ALTER TABLE `accountreport`
  MODIFY `ORNumber` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=41;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
