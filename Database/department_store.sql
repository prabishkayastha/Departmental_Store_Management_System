-- phpMyAdmin SQL Dump
-- version 4.6.5.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Aug 11, 2017 at 09:26 AM
-- Server version: 10.1.21-MariaDB
-- PHP Version: 5.6.30

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `department_store`
--

-- --------------------------------------------------------

--
-- Table structure for table `bakery`
--

CREATE TABLE `bakery` (
  `item_name` varchar(15) NOT NULL,
  `quantity` int(20) DEFAULT NULL,
  `manu_id` varchar(20) DEFAULT NULL,
  `price` float(20,2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `bakery`
--

INSERT INTO `bakery` (`item_name`, `quantity`, `manu_id`, `price`) VALUES
('Bun', 449, '6', 40.00),
('Chocolate Cake', 100, '3', 200.00),
('Vanilla Cake', 500, '3', 300.00);

-- --------------------------------------------------------

--
-- Table structure for table `beverage`
--

CREATE TABLE `beverage` (
  `item_name` varchar(20) NOT NULL,
  `quantity` int(20) DEFAULT NULL,
  `manu_id` varchar(20) DEFAULT NULL,
  `price` float(20,2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `beverage`
--

INSERT INTO `beverage` (`item_name`, `quantity`, `manu_id`, `price`) VALUES
('Heineken', 1500, '1', 500.00),
('Nepalice', 499, '1', 220.00),
('Tuborg', 1000, '1', 250.00);

-- --------------------------------------------------------

--
-- Table structure for table `cart`
--

CREATE TABLE `cart` (
  `item_name` varchar(20) DEFAULT NULL,
  `quantity_added` int(10) DEFAULT NULL,
  `amount` float(20,2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `cereal`
--

CREATE TABLE `cereal` (
  `item_name` varchar(20) NOT NULL,
  `quantity` int(20) DEFAULT NULL,
  `manu_id` varchar(20) DEFAULT NULL,
  `price` float(20,2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `cereal`
--

INSERT INTO `cereal` (`item_name`, `quantity`, `manu_id`, `price`) VALUES
('Legume', 1500, '1', 80.00),
('Maize', 1500, '1', 60.00),
('Wheat', 2000, '1', 50.00);

-- --------------------------------------------------------

--
-- Table structure for table `chocolate`
--

CREATE TABLE `chocolate` (
  `item_name` varchar(20) NOT NULL,
  `quantity` int(20) DEFAULT NULL,
  `manu_id` varchar(20) DEFAULT NULL,
  `price` float(20,2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 ROW_FORMAT=COMPACT;

--
-- Dumping data for table `chocolate`
--

INSERT INTO `chocolate` (`item_name`, `quantity`, `manu_id`, `price`) VALUES
('Dairy Milk Mix', 495, '2', 80.00),
('Dairy Milk Silk', 500, '1', 80.00),
('Snickers', 300, '3', 120.00);

-- --------------------------------------------------------

--
-- Table structure for table `customer`
--

CREATE TABLE `customer` (
  `cust_id` varchar(10) NOT NULL,
  `customer_name` varchar(20) DEFAULT NULL,
  `address` varchar(20) DEFAULT NULL,
  `phone_number` varchar(12) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `customer`
--

INSERT INTO `customer` (`cust_id`, `customer_name`, `address`, `phone_number`) VALUES
('1', 'Birat', 'Sanga', '9842568435'),
('2', 'Rasil Baidar', 'Banepa', '9843532537');

-- --------------------------------------------------------

--
-- Table structure for table `dairy`
--

CREATE TABLE `dairy` (
  `item_name` varchar(15) NOT NULL,
  `quantity` int(20) DEFAULT NULL,
  `manu_id` varchar(20) DEFAULT NULL,
  `price` float(20,2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `dairy`
--

INSERT INTO `dairy` (`item_name`, `quantity`, `manu_id`, `price`) VALUES
('Butter Milk', 1500, '8', 100.00),
('Whole Milk', 1000, '7', 75.00);

-- --------------------------------------------------------

--
-- Table structure for table `dealer_info`
--

CREATE TABLE `dealer_info` (
  `dealer_name` char(20) NOT NULL,
  `category` varchar(20) NOT NULL,
  `phone_no` varchar(15) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `grains`
--

CREATE TABLE `grains` (
  `item_name` varchar(20) NOT NULL,
  `quantity` int(20) DEFAULT NULL,
  `manu_id` varchar(20) DEFAULT NULL,
  `price` float(20,2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `grains`
--

INSERT INTO `grains` (`item_name`, `quantity`, `manu_id`, `price`) VALUES
('Apple Rice', 1000, '1', 100.00),
('Basmati Rice', 2000, '1', 120.00),
('Sangram Rice', 1500, '1', 80.00);

-- --------------------------------------------------------

--
-- Table structure for table `jarred__canned`
--

CREATE TABLE `jarred__canned` (
  `item_name` varchar(20) NOT NULL,
  `quantity` int(20) DEFAULT NULL,
  `manu_id` varchar(20) DEFAULT NULL,
  `price` float(20,2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `jarred__canned`
--

INSERT INTO `jarred__canned` (`item_name`, `quantity`, `manu_id`, `price`) VALUES
('Jam', 1000, '9', 150.00),
('Mango Pickle', 1500, '10', 250.00);

-- --------------------------------------------------------

--
-- Table structure for table `junk_food`
--

CREATE TABLE `junk_food` (
  `item_name` varchar(20) NOT NULL,
  `quantity` int(20) DEFAULT NULL,
  `manu_id` varchar(20) DEFAULT NULL,
  `price` float(20,2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `junk_food`
--

INSERT INTO `junk_food` (`item_name`, `quantity`, `manu_id`, `price`) VALUES
('Chau Chau', 2000, '1', 20.00),
('Kurkure', 2500, '1', 50.00),
('Lays', 2000, '1', 40.00),
('Papad', 1500, '1', 25.00),
('Prawn', 1700, '1', 50.00);

-- --------------------------------------------------------

--
-- Table structure for table `login`
--

CREATE TABLE `login` (
  `username` varchar(15) NOT NULL,
  `password` varchar(15) NOT NULL,
  `staff_id` varchar(15) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `login`
--

INSERT INTO `login` (`username`, `password`, `staff_id`) VALUES
('1', '1', '1');

-- --------------------------------------------------------

--
-- Table structure for table `manufacturer`
--

CREATE TABLE `manufacturer` (
  `manu_id` varchar(10) NOT NULL,
  `manu_name` varchar(40) DEFAULT NULL,
  `address` varchar(20) DEFAULT NULL,
  `phone_num` varchar(15) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `manufacturer`
--

INSERT INTO `manufacturer` (`manu_id`, `manu_name`, `address`, `phone_num`) VALUES
('1', 'Chaudhary_group', 'Kathmandu', '9841658752'),
('10', 'Pickle Supply', 'Banepa', '98808457898'),
('11', 'Toiletaries Supply', 'Chitwan', '9845658725'),
('2', 'Cadbury', 'Kathmandu', '9841488752'),
('3', 'Mars', 'Bhaktapur', '9818658752'),
('4', 'Nestle', 'Birgunj', '9841689752'),
('5', 'Bourborn', 'Kathmandu', '9841658352'),
('6', 'Lottee', 'Biratnagar', '9841455252'),
('7', 'Biratnagar Milk Supply', 'Biratnagar', '9842458778'),
('8', 'Kathmandu Milk Supply', 'Kathmandu', '9841543248'),
('9', 'Jam Manufacturer', 'Birgunj', '9843568978');

-- --------------------------------------------------------

--
-- Table structure for table `orders`
--

CREATE TABLE `orders` (
  `order_id` int(15) NOT NULL,
  `cust_id` varchar(15) DEFAULT NULL,
  `cust_name` varchar(20) NOT NULL,
  `cust_phone` varchar(15) NOT NULL,
  `order_date` date NOT NULL,
  `address` varchar(15) DEFAULT NULL,
  `Delivery_Status` tinyint(1) NOT NULL DEFAULT '0',
  `amount` float(20,2) NOT NULL,
  `bill_no` bigint(15) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `orders`
--

INSERT INTO `orders` (`order_id`, `cust_id`, `cust_name`, `cust_phone`, `order_date`, `address`, `Delivery_Status`, `amount`, `bill_no`) VALUES
(1, '1', 'fjaklsd', '259198198', '2017-08-06', '', 1, 160.00, NULL),
(3, '1', 'Birat', '9842568435', '2017-08-09', 'Sanga', 1, 1026.00, 119),
(4, '2', 'Rasil Baidar', '9843532537', '2017-08-09', 'Banepa', 1, 2280.00, 120),
(5, '2', 'Rasil Baidar', '9843532537', '2017-08-09', 'Banepa', 1, 114.00, 121),
(6, '1', 'Birat', '9842568435', '2017-08-09', 'Sanga', 1, 5700.00, 122),
(7, '2', 'Rasil Baidar', '9843532537', '2017-08-09', 'Banepa', 1, 3420.00, 123),
(8, '1', 'Birat', '9842568435', '2017-08-09', 'Sanga', 1, 304.00, 124);

-- --------------------------------------------------------

--
-- Table structure for table `orders_product_detail`
--

CREATE TABLE `orders_product_detail` (
  `order_id` int(15) NOT NULL,
  `product_name` varchar(20) NOT NULL,
  `quantity` int(20) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `orders_product_detail`
--

INSERT INTO `orders_product_detail` (`order_id`, `product_name`, `quantity`) VALUES
(1, 'Snickers', 2),
(4, 'Dairy Milk Silk', 30),
(5, 'Snickers', 1),
(6, 'Snickers', 50),
(7, 'Snickers', 30),
(8, 'Dairy Milk Mix', 4);

-- --------------------------------------------------------

--
-- Table structure for table `order_cart`
--

CREATE TABLE `order_cart` (
  `item_name` varchar(20) DEFAULT NULL,
  `quantity_added` int(10) DEFAULT NULL,
  `amount` float(20,2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `sales_data`
--

CREATE TABLE `sales_data` (
  `bill_no` bigint(15) NOT NULL,
  `amount` float(25,2) DEFAULT NULL,
  `cust_id` varchar(15) DEFAULT 'Unregisterd',
  `timestamp` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `sales_data`
--

INSERT INTO `sales_data` (`bill_no`, `amount`, `cust_id`, `timestamp`) VALUES
(1, 4000.00, '1', '2017-08-04'),
(2, 960.00, '1', '2017-08-04'),
(3, NULL, NULL, '0000-00-00'),
(4, 960.00, NULL, '2017-08-04'),
(5, 960.00, NULL, '2017-08-04'),
(6, 160.00, NULL, '2017-08-04'),
(7, 680.00, NULL, '2017-08-04'),
(8, 280.00, NULL, '2017-08-04'),
(9, 1140.00, '1', '2017-08-05'),
(10, 2764.50, '1', '2017-08-05'),
(11, 5424.50, '2', '2017-08-05'),
(12, 7695.00, '1', '2017-08-05'),
(13, 5700.00, '1', '2017-08-05'),
(14, 3420.00, '2', '2017-08-05'),
(15, 7049.00, '1', '2017-08-05'),
(16, 3420.00, '2', '2017-08-05'),
(17, 3420.00, '2', '2017-08-05'),
(18, 5700.00, '2', '2017-08-05'),
(19, 5700.00, '1', '2017-08-05'),
(20, 5700.00, '2', '2017-08-05'),
(21, 5700.00, '1', '2017-08-05'),
(22, 5700.00, '2', '2017-08-05'),
(23, 5700.00, '1', '2017-08-05'),
(24, 5700.00, '1', '2017-08-05'),
(25, 5700.00, '1', '2017-08-05'),
(26, 5700.00, '1', '2017-08-05'),
(27, 342.00, '2', '2017-08-05'),
(28, 5700.00, '1', '2017-08-05'),
(29, 5700.00, '1', '2017-08-05'),
(30, 5700.00, '1', '2017-08-05'),
(31, 5700.00, '1', '2017-08-05'),
(32, 5700.00, '1', '2017-08-05'),
(33, 5700.00, '1', '2017-08-05'),
(34, 5700.00, '1', '2017-08-05'),
(35, 5700.00, '1', '2017-08-05'),
(36, 11115.00, '1', '2017-08-05'),
(37, 5700.00, '1', '2017-08-05'),
(38, 5700.00, '1', '2017-08-05'),
(39, 11115.00, '1', '2017-08-05'),
(40, 5700.00, '1', '2017-08-05'),
(41, 5700.00, '1', '2017-08-05'),
(42, 5700.00, '1', '2017-08-05'),
(43, 5700.00, '1', '2017-08-05'),
(44, 5700.00, '1', '2017-08-05'),
(45, 5700.00, '1', '2017-08-05'),
(46, 5700.00, '1', '2017-08-05'),
(47, 5700.00, '1', '2017-08-05'),
(48, 5700.00, '1', '2017-08-05'),
(49, 6840.00, '1', '2017-08-04'),
(50, 5700.00, '1', '2017-08-04'),
(51, 5700.00, '2', '2017-08-04'),
(52, 9120.00, '1', '2017-08-04'),
(53, 5700.00, '1', '2017-08-04'),
(54, 5700.00, '1', '2017-08-05'),
(55, 5700.00, '1', '2017-08-05'),
(56, 5700.00, '1', '2017-08-05'),
(57, 5700.00, '1', '2017-08-05'),
(58, 5700.00, '1', '2017-08-05'),
(59, 5700.00, '1', '2017-08-05'),
(60, 5700.00, '1', '2017-08-05'),
(61, 5700.00, '1', '2017-08-05'),
(62, 5700.00, '1', '2017-08-05'),
(63, 5700.00, '1', '2017-08-05'),
(64, 5700.00, '1', '2017-08-05'),
(65, 5700.00, '1', '2017-08-05'),
(66, 11115.00, '1', '2017-08-05'),
(67, 5700.00, '1', '2017-08-05'),
(68, 11115.00, '1', '2017-08-05'),
(69, 5700.00, '1', '2017-08-05'),
(70, 5700.00, '1', '2017-08-05'),
(71, 5700.00, '1', '2017-08-05'),
(72, 5700.00, '1', '2017-08-05'),
(73, 5700.00, '1', '2017-08-05'),
(74, 5700.00, '1', '2017-08-05'),
(75, 5700.00, '1', '2017-08-05'),
(76, 104500.00, '1', '2017-08-05'),
(77, 5700.00, '1', '2017-08-05'),
(78, 5700.00, '1', '2017-08-05'),
(79, 1900.00, '1', '2017-08-05'),
(80, 7505.00, '1', '2017-08-05'),
(81, 456.00, '2', '2017-08-06'),
(82, 456.00, '1', '2017-08-06'),
(83, 480.00, '1', '2017-08-06'),
(84, 456.00, '1', '2017-08-06'),
(85, 456.00, '1', '2017-08-06'),
(86, 456.00, '1', '2017-08-06'),
(87, 456.00, '1', '2017-08-06'),
(88, 456.00, '1', '2017-08-06'),
(89, 456.00, '2', '2017-08-06'),
(90, 456.00, '1', '2017-08-06'),
(91, 456.00, '1', '2017-08-06'),
(92, 456.00, '1', '2017-08-06'),
(93, 456.00, '2', '2017-08-06'),
(94, 456.00, '1', '2017-08-06'),
(95, 456.00, '1', '2017-08-06'),
(96, 456.00, '1', '2017-08-06'),
(97, 456.00, '1', '2017-08-06'),
(98, 456.00, '1', '2017-08-06'),
(99, 456.00, '1', '2017-08-06'),
(100, 456.00, '2', '2017-08-06'),
(101, 456.00, '1', '2017-08-06'),
(102, 456.00, '1', '2017-08-06'),
(103, 456.00, '1', '2017-08-06'),
(104, 456.00, '1', '2017-08-06'),
(105, 456.00, '1', '2017-08-06'),
(106, 456.00, '1', '2017-08-06'),
(107, 456.00, '1', '2017-08-06'),
(108, 1900.00, '1', '2017-08-06'),
(109, 684.00, '1', '2017-08-06'),
(110, 2000.00, NULL, '2017-08-06'),
(111, 1200.00, NULL, '2017-08-06'),
(112, 400.00, NULL, '2017-08-06'),
(113, 1600.00, NULL, '2017-08-06'),
(114, 15000.00, NULL, '2017-08-06'),
(115, 11000.00, NULL, '2017-08-06'),
(116, 18600.00, NULL, '2017-08-06'),
(117, 398.46, '1', '2017-08-06'),
(118, 1026.00, '1', '2017-08-09'),
(119, 1026.00, '1', '2017-08-09'),
(120, 2280.00, '2', '2017-08-09'),
(121, 114.00, '2', '2017-08-09'),
(122, 5700.00, '1', '2017-08-09'),
(123, 3420.00, '2', '2017-08-09'),
(124, 304.00, '1', '2017-08-09');

-- --------------------------------------------------------

--
-- Table structure for table `staff`
--

CREATE TABLE `staff` (
  `Staff_ID` varchar(10) NOT NULL,
  `staff_name` varchar(32) DEFAULT NULL,
  `sex` varchar(10) NOT NULL,
  `Designation` varchar(10) DEFAULT NULL,
  `phone_num` varchar(11) DEFAULT NULL,
  `address` varchar(10) DEFAULT NULL,
  `salary` int(10) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `staff`
--

INSERT INTO `staff` (`Staff_ID`, `staff_name`, `sex`, `Designation`, `phone_num`, `address`, `salary`) VALUES
('1', 'Prabish', 'Male', 'manager', '2147483647', 'Banepa', 50000),
('2', 'Rasil', 'Male', 'salesboy', '9813548698', 'Banepa', 6000),
('3', 'susmita', 'Female', 'accountant', '9843547815', 'Panauti', 12000),
('5', 'Birat', 'Male', 'salesman', '9841543745', 'Sanga', 5000);

-- --------------------------------------------------------

--
-- Table structure for table `toiletaries`
--

CREATE TABLE `toiletaries` (
  `item_name` varchar(20) NOT NULL,
  `quantity` int(20) DEFAULT NULL,
  `manu_id` varchar(20) DEFAULT NULL,
  `price` float(20,2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `toiletaries`
--

INSERT INTO `toiletaries` (`item_name`, `quantity`, `manu_id`, `price`) VALUES
('Dettol Hand Wash', 1500, '11', 80.00),
('Dettol Soap', 2500, '11', 100.00),
('Lifeboy Soap', 2500, '11', 45.00),
('Toilet Paper', 2000, '11', 50.00);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `bakery`
--
ALTER TABLE `bakery`
  ADD PRIMARY KEY (`item_name`),
  ADD KEY `manu_id` (`manu_id`);

--
-- Indexes for table `beverage`
--
ALTER TABLE `beverage`
  ADD PRIMARY KEY (`item_name`),
  ADD KEY `manu_id` (`manu_id`);

--
-- Indexes for table `cereal`
--
ALTER TABLE `cereal`
  ADD PRIMARY KEY (`item_name`),
  ADD KEY `manu_id` (`manu_id`);

--
-- Indexes for table `chocolate`
--
ALTER TABLE `chocolate`
  ADD PRIMARY KEY (`item_name`),
  ADD KEY `manu_id` (`manu_id`);

--
-- Indexes for table `customer`
--
ALTER TABLE `customer`
  ADD PRIMARY KEY (`cust_id`);

--
-- Indexes for table `dairy`
--
ALTER TABLE `dairy`
  ADD PRIMARY KEY (`item_name`),
  ADD KEY `manu_id` (`manu_id`);

--
-- Indexes for table `dealer_info`
--
ALTER TABLE `dealer_info`
  ADD PRIMARY KEY (`dealer_name`,`category`),
  ADD KEY `category` (`category`);

--
-- Indexes for table `grains`
--
ALTER TABLE `grains`
  ADD PRIMARY KEY (`item_name`),
  ADD KEY `manu_id` (`manu_id`);

--
-- Indexes for table `jarred__canned`
--
ALTER TABLE `jarred__canned`
  ADD PRIMARY KEY (`item_name`),
  ADD KEY `manu_id` (`manu_id`);

--
-- Indexes for table `junk_food`
--
ALTER TABLE `junk_food`
  ADD PRIMARY KEY (`item_name`),
  ADD KEY `manu_id` (`manu_id`);

--
-- Indexes for table `login`
--
ALTER TABLE `login`
  ADD PRIMARY KEY (`staff_id`);

--
-- Indexes for table `manufacturer`
--
ALTER TABLE `manufacturer`
  ADD PRIMARY KEY (`manu_id`);

--
-- Indexes for table `orders`
--
ALTER TABLE `orders`
  ADD PRIMARY KEY (`order_id`),
  ADD KEY `cust_id` (`cust_id`),
  ADD KEY `bill_no` (`bill_no`);

--
-- Indexes for table `orders_product_detail`
--
ALTER TABLE `orders_product_detail`
  ADD PRIMARY KEY (`order_id`,`product_name`);

--
-- Indexes for table `sales_data`
--
ALTER TABLE `sales_data`
  ADD PRIMARY KEY (`bill_no`),
  ADD KEY `cust_id` (`cust_id`);

--
-- Indexes for table `staff`
--
ALTER TABLE `staff`
  ADD PRIMARY KEY (`Staff_ID`);

--
-- Indexes for table `toiletaries`
--
ALTER TABLE `toiletaries`
  ADD PRIMARY KEY (`item_name`),
  ADD KEY `manu_id` (`manu_id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `orders`
--
ALTER TABLE `orders`
  MODIFY `order_id` int(15) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;
--
-- AUTO_INCREMENT for table `sales_data`
--
ALTER TABLE `sales_data`
  MODIFY `bill_no` bigint(15) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=125;
--
-- Constraints for dumped tables
--

--
-- Constraints for table `bakery`
--
ALTER TABLE `bakery`
  ADD CONSTRAINT `bakery_ibfk_1` FOREIGN KEY (`manu_id`) REFERENCES `manufacturer` (`manu_id`);

--
-- Constraints for table `beverage`
--
ALTER TABLE `beverage`
  ADD CONSTRAINT `beverage_ibfk_1` FOREIGN KEY (`manu_id`) REFERENCES `manufacturer` (`manu_id`);

--
-- Constraints for table `cereal`
--
ALTER TABLE `cereal`
  ADD CONSTRAINT `cereal_ibfk_1` FOREIGN KEY (`manu_id`) REFERENCES `manufacturer` (`manu_id`);

--
-- Constraints for table `chocolate`
--
ALTER TABLE `chocolate`
  ADD CONSTRAINT `chocolate_ibfk_1` FOREIGN KEY (`manu_id`) REFERENCES `manufacturer` (`manu_id`);

--
-- Constraints for table `dairy`
--
ALTER TABLE `dairy`
  ADD CONSTRAINT `dairy_ibfk_1` FOREIGN KEY (`manu_id`) REFERENCES `manufacturer` (`manu_id`);

--
-- Constraints for table `login`
--
ALTER TABLE `login`
  ADD CONSTRAINT `login_ibfk_1` FOREIGN KEY (`staff_id`) REFERENCES `staff` (`Staff_ID`) ON DELETE CASCADE ON UPDATE CASCADE;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
