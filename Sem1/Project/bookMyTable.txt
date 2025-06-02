-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Dec 26, 2024 at 12:23 AM
-- Server version: 10.4.32-MariaDB
-- PHP Version: 8.0.30

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `bookmytable`
--

-- --------------------------------------------------------

--
-- Table structure for table `bookings`
--

CREATE TABLE `bookings` (
  `bookingId` int(100) NOT NULL,
  `userId` int(100) NOT NULL,
  `restaurantId` int(100) NOT NULL,
  `bookingDate` date NOT NULL,
  `bookingTime` time NOT NULL,
  `specialRequest` varchar(255) NOT NULL,
  `guestCount` int(100) NOT NULL,
  `status` varchar(100) NOT NULL,
  `otpVerification` tinyint(1) NOT NULL,
  `createdAt` timestamp NOT NULL DEFAULT current_timestamp(),
  `updatedAt` timestamp NOT NULL DEFAULT current_timestamp() ON UPDATE current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `bookings`
--

INSERT INTO `bookings` (`bookingId`, `userId`, `restaurantId`, `bookingDate`, `bookingTime`, `specialRequest`, `guestCount`, `status`, `otpVerification`, `createdAt`, `updatedAt`) VALUES
(12, 2, 8, '2024-10-31', '23:12:01', 'xyz...', 4, 'Aproved', 1, '2024-11-23 07:29:16', '2024-12-15 13:44:45'),
(13, 11, 8, '2024-12-01', '08:35:30', 'Abcdef...', 20, 'ava', 0, '2024-12-16 02:07:21', '2024-12-16 04:22:29'),
(14, 2, 8, '2024-10-30', '23:12:01', 'abc..', 3, 'confirmed', 0, '2024-12-19 09:37:42', '2024-12-19 09:37:42'),
(16, 2, 8, '2024-10-30', '23:12:01', 'bday', 2, 'confirmed', 0, '2024-12-19 09:38:57', '2024-12-19 09:38:57'),
(42, 2, 13, '2024-12-20', '14:47:14', 'qwqwqw', 4, 'confirmed', 0, '2024-12-19 11:00:49', '2024-12-19 11:00:49'),
(43, 2, 8, '2024-12-20', '14:47:14', 'hello from kathiyawadi', 5, 'confirmed', 0, '2024-12-19 11:05:36', '2024-12-19 11:05:36'),
(44, 2, 8, '2024-12-22', '06:13:08', 'helloooooo', 3, 'confirmed', 0, '2024-12-19 11:13:48', '2024-12-19 11:13:48'),
(45, 12, 13, '2024-12-22', '06:13:08', 'hello', 15, 'confirmed', 0, '2024-12-22 05:39:28', '2024-12-22 07:06:22'),
(46, 12, 13, '2024-12-22', '10:00:00', 'bday', 5, 'confirmed', 0, '2024-12-22 06:39:50', '2024-12-22 06:39:50'),
(47, 12, 13, '2024-12-22', '10:00:00', 'anniversary', 7, 'confirmed', 0, '2024-12-22 07:45:23', '2024-12-22 07:45:23'),
(48, 12, 13, '2024-12-22', '10:00:00', 'wedding', 7, 'confirmed', 0, '2024-12-22 08:02:34', '2024-12-22 08:02:34'),
(49, 12, 8, '2024-12-22', '10:00:00', 'shgdhgshdg', 15, 'confirmed', 0, '2024-12-22 08:32:36', '2024-12-22 08:32:36'),
(52, 20, 13, '2024-12-21', '04:15:23', 'abcd..', 5, 'confirmed', 0, '2024-12-23 08:42:58', '2024-12-23 08:42:58'),
(53, 12, 35, '2024-12-21', '04:15:23', 'abc...', 5, 'confirmed', 0, '2024-12-23 18:06:30', '2024-12-23 18:06:30'),
(55, 12, 35, '2024-12-24', '03:26:08', 'trdyfy', 5, 'confirmed', 0, '2024-12-24 08:25:43', '2024-12-24 08:25:43'),
(56, 12, 8, '2024-12-25', '04:15:23', 'wserdtfgyh', 5, 'confirmed', 0, '2024-12-25 10:31:11', '2024-12-25 10:31:11'),
(61, 12, 8, '2024-12-17', '04:15:23', 'helll', 8, 'confirmed', 0, '2024-12-25 12:01:06', '2024-12-25 12:01:06'),
(69, 19, 8, '2024-12-21', '04:15:23', 'hello', 8, 'confirmed', 0, '2024-12-25 12:29:38', '2024-12-25 12:29:38'),
(70, 19, 8, '2024-12-21', '04:15:23', 'hello', 8, 'confirmed', 0, '2024-12-25 12:32:23', '2024-12-25 12:32:23'),
(71, 19, 37, '2024-12-26', '07:15:23', 'plz clear the table', 3, 'confirmed', 0, '2024-12-25 14:57:17', '2024-12-25 14:57:17'),
(76, 19, 8, '2024-12-27', '04:18:18', 'hello', 5, 'confirmed', 0, '2024-12-25 18:04:41', '2024-12-25 18:04:41');

-- --------------------------------------------------------

--
-- Table structure for table `cities`
--

CREATE TABLE `cities` (
  `cityId` int(100) NOT NULL,
  `stateId` int(100) NOT NULL,
  `cityName` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `cities`
--

INSERT INTO `cities` (`cityId`, `stateId`, `cityName`) VALUES
(1, 2, 'Rajkot'),
(7, 4, 'Pune'),
(10, 2, 'Surat'),
(11, 2, 'Amreli');

-- --------------------------------------------------------

--
-- Table structure for table `contact`
--

CREATE TABLE `contact` (
  `contactid` int(100) NOT NULL,
  `userId` int(100) NOT NULL,
  `name` varchar(200) NOT NULL,
  `emailId` varchar(200) NOT NULL,
  `subject` varchar(200) NOT NULL,
  `message` varchar(200) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `contact`
--

INSERT INTO `contact` (`contactid`, `userId`, `name`, `emailId`, `subject`, `message`) VALUES
(1, 2, 'sds', 'sds', 'sds', 'ssc'),
(2, 2, 'dhruvi vavadiya', 'dhruvi@gmail.com', 'abc', 'abc..'),
(3, 19, 'dhruvi vavdiya', 'abc@gmail.com', 'xyz', 'adsdfvg');

-- --------------------------------------------------------

--
-- Table structure for table `cuisinetype`
--

CREATE TABLE `cuisinetype` (
  `cuisineId` int(100) NOT NULL,
  `cuisineName` varchar(100) NOT NULL,
  `cuisinePhoto` varchar(500) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `cuisinetype`
--

INSERT INTO `cuisinetype` (`cuisineId`, `cuisineName`, `cuisinePhoto`) VALUES
(1, 'Gujarati', 'gujarati.jpeg'),
(2, 'Chinese', 'Chaine.jpg'),
(3, 'Italian', 'italian.jpg'),
(10, 'south indian', 'southIndian.webp');

-- --------------------------------------------------------

--
-- Table structure for table `groupmaster`
--

CREATE TABLE `groupmaster` (
  `groupId` int(100) NOT NULL,
  `groupName` varchar(100) NOT NULL,
  `userName` varchar(200) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `groupmaster`
--

INSERT INTO `groupmaster` (`groupId`, `groupName`, `userName`) VALUES
(1, 'Supervisor', 'user'),
(2, 'Owner', 'dhruv'),
(3, 'Admin', 'admin'),
(5, 'Owner', 'priyanka'),
(6, 'Supervisor', 'janu'),
(15, 'Owner', 'dhruvi'),
(16, 'Supervisor', 'nency'),
(17, 'Owner', 'abc'),
(18, 'Owner', 'xyz'),
(19, 'Owner', 'mahesh'),
(20, 'Supervisor', 'janvi');

-- --------------------------------------------------------

--
-- Table structure for table `menuitems`
--

CREATE TABLE `menuitems` (
  `itemId` int(100) NOT NULL,
  `restaurantId` int(100) NOT NULL,
  `itemName` varchar(100) NOT NULL,
  `itemDescription` varchar(100) NOT NULL,
  `price` int(100) NOT NULL,
  `itemAvailability` varchar(100) NOT NULL,
  `itemPhoto` varchar(255) NOT NULL,
  `createdAt` timestamp NOT NULL DEFAULT current_timestamp(),
  `updatedAt` timestamp NOT NULL DEFAULT current_timestamp() ON UPDATE current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `menuitems`
--

INSERT INTO `menuitems` (`itemId`, `restaurantId`, `itemName`, `itemDescription`, `price`, `itemAvailability`, `itemPhoto`, `createdAt`, `updatedAt`) VALUES
(30, 8, 'Manchurian', 'manchurian', 500, 'available', 'manchurian.jpeg', '2024-12-14 11:20:13', '2024-12-25 16:01:04'),
(31, 28, 'Pizza', 'pizza', 150, 'available', 'pizza.jpeg', '2024-12-14 09:32:12', '2024-12-25 16:28:50'),
(35, 8, 'Burger', 'burger', 299, 'available', 'burger.jpg', '2024-12-14 10:06:07', '2024-12-25 16:13:23'),
(36, 28, 'Sandwich', 'sandwitch', 200, 'available', 'sandwitch.jpg', '2024-12-14 10:08:39', '2024-12-25 16:28:55'),
(38, 15, 'Pavbhaji', 'pavbhaji', 266, 'available', 'pavbhaji.jpeg', '2024-12-22 10:40:44', '2024-12-25 16:29:18'),
(39, 35, 'French-fries', 'french_fries', 250, 'available', 'french-fries.jpeg', '2024-12-23 17:59:44', '2024-12-25 16:13:07'),
(40, 13, 'Passta', 'passta', 520, 'available', 'passta.jpeg', '2024-12-24 00:34:48', '2024-12-25 16:29:36'),
(42, 28, 'Garlic-bread', 'Garlic-bread', 200, 'available', 'Garlic-bread.jpg', '2024-12-24 00:50:40', '2024-12-25 16:35:17'),
(44, 28, 'dhosa', 'dhosa', 60, 'available', 'IMG_470405915402dosa.png', '2024-12-25 14:52:36', '2024-12-25 16:29:09'),
(45, 15, 'Burger', 'burger', 255, 'available', 'burger.jpg', '2024-12-25 16:32:42', '2024-12-25 16:33:32'),
(46, 17, 'Pavbhaji', 'pavbhaji', 255, 'available', 'pavbhaji.jpeg', '2024-12-25 16:32:51', '2024-12-25 16:33:58');

-- --------------------------------------------------------

--
-- Table structure for table `multipletablebooking`
--

CREATE TABLE `multipletablebooking` (
  `multiTableId` int(100) NOT NULL,
  `bookingId` int(100) NOT NULL,
  `tableId` int(100) NOT NULL,
  `assignedGuest` int(100) NOT NULL,
  `createdAt` timestamp NOT NULL DEFAULT current_timestamp(),
  `updatedAt` timestamp NOT NULL DEFAULT current_timestamp() ON UPDATE current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `multipletablebooking`
--

INSERT INTO `multipletablebooking` (`multiTableId`, `bookingId`, `tableId`, `assignedGuest`, `createdAt`, `updatedAt`) VALUES
(26, 12, 16, 10, '2024-11-23 07:29:30', '2024-11-23 07:29:30'),
(53, 42, 18, 4, '2024-12-19 11:00:49', '2024-12-19 11:00:49'),
(54, 43, 16, 5, '2024-12-19 11:05:36', '2024-12-19 11:05:36'),
(55, 44, 16, 3, '2024-12-19 11:13:48', '2024-12-19 11:13:48'),
(56, 45, 19, 5, '2024-12-22 05:39:28', '2024-12-22 05:39:28'),
(57, 45, 18, 10, '2024-12-22 05:39:28', '2024-12-22 05:39:28'),
(58, 46, 19, 5, '2024-12-22 06:39:50', '2024-12-22 06:39:50'),
(59, 47, 19, 7, '2024-12-22 07:45:23', '2024-12-22 07:45:23'),
(60, 48, 19, 7, '2024-12-22 08:02:34', '2024-12-22 08:02:34'),
(61, 49, 16, 15, '2024-12-22 08:32:36', '2024-12-22 08:32:36'),
(62, 52, 19, 5, '2024-12-23 08:42:58', '2024-12-23 08:42:58'),
(63, 53, 19, 5, '2024-12-23 18:06:30', '2024-12-23 18:06:30'),
(64, 55, 19, 5, '2024-12-24 08:25:43', '2024-12-24 08:25:43'),
(65, 56, 16, 5, '2024-12-25 10:31:11', '2024-12-25 10:31:11'),
(66, 61, 16, 8, '2024-12-25 12:01:06', '2024-12-25 12:01:06'),
(67, 69, 16, 8, '2024-12-25 12:29:38', '2024-12-25 12:29:38'),
(68, 70, 16, 8, '2024-12-25 12:32:23', '2024-12-25 12:32:23'),
(69, 71, 24, 3, '2024-12-25 14:57:17', '2024-12-25 14:57:17'),
(70, 76, 16, 5, '2024-12-25 18:04:41', '2024-12-25 18:04:41');

-- --------------------------------------------------------

--
-- Table structure for table `orderitems`
--

CREATE TABLE `orderitems` (
  `orderItemId` int(100) NOT NULL,
  `orderId` int(100) NOT NULL,
  `itemId` int(100) NOT NULL,
  `quantity` int(100) NOT NULL,
  `price` int(100) NOT NULL,
  `createdAt` timestamp NOT NULL DEFAULT current_timestamp(),
  `updatedAt` timestamp NOT NULL DEFAULT current_timestamp() ON UPDATE current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `orderitems`
--

INSERT INTO `orderitems` (`orderItemId`, `orderId`, `itemId`, `quantity`, `price`, `createdAt`, `updatedAt`) VALUES
(11, 6, 30, 12, 200, '2024-11-23 07:46:10', '2024-11-23 07:46:10'),
(12, 6, 31, 10, 278, '2024-12-14 10:30:51', '2024-12-14 10:30:51'),
(14, 16, 36, 2, 400, '2024-12-22 08:33:09', '2024-12-22 08:33:09'),
(15, 16, 30, 2, 1000, '2024-12-22 08:33:09', '2024-12-22 08:33:09'),
(16, 17, 35, 1, 299, '2024-12-22 08:48:17', '2024-12-22 08:48:17'),
(17, 17, 31, 1, 150, '2024-12-22 08:48:17', '2024-12-22 08:48:17'),
(18, 18, 30, 1, 500, '2024-12-22 08:51:59', '2024-12-22 08:51:59'),
(19, 18, 31, 1, 150, '2024-12-22 08:51:59', '2024-12-22 08:51:59'),
(20, 19, 31, 1, 150, '2024-12-22 08:57:10', '2024-12-22 08:57:10'),
(21, 20, 30, 1, 500, '2024-12-22 08:59:56', '2024-12-22 08:59:56'),
(22, 21, 36, 1, 200, '2024-12-22 09:32:56', '2024-12-22 09:32:56'),
(23, 22, 36, 1, 200, '2024-12-22 09:33:56', '2024-12-22 09:33:56'),
(24, 23, 30, 2, 1000, '2024-12-22 09:51:41', '2024-12-22 09:51:41'),
(25, 23, 31, 1, 150, '2024-12-22 09:51:41', '2024-12-22 09:51:41'),
(26, 24, 38, 3, 798, '2024-12-23 08:44:11', '2024-12-23 08:44:11'),
(27, 25, 38, 3, 798, '2024-12-23 08:46:05', '2024-12-23 08:46:05'),
(28, 26, 39, 1, 250, '2024-12-23 18:08:12', '2024-12-23 18:08:12'),
(29, 27, 39, 2, 500, '2024-12-24 08:26:20', '2024-12-24 08:26:20'),
(30, 27, 40, 2, 1040, '2024-12-24 08:26:20', '2024-12-24 08:26:20'),
(31, 28, 35, 1, 299, '2024-12-25 10:33:03', '2024-12-25 10:33:03'),
(32, 28, 30, 1, 500, '2024-12-25 10:33:03', '2024-12-25 10:33:03'),
(33, 28, 31, 2, 300, '2024-12-25 10:33:04', '2024-12-25 10:33:04'),
(34, 29, 44, 4, 240, '2024-12-25 14:59:38', '2024-12-25 14:59:38');

-- --------------------------------------------------------

--
-- Table structure for table `orders`
--

CREATE TABLE `orders` (
  `orderId` int(100) NOT NULL,
  `userId` int(100) NOT NULL,
  `bookingId` int(100) NOT NULL,
  `restaurantId` int(100) NOT NULL,
  `totalAmount` int(100) NOT NULL,
  `status` varchar(100) NOT NULL,
  `createdAt` timestamp NOT NULL DEFAULT current_timestamp(),
  `updatedAt` timestamp NOT NULL DEFAULT current_timestamp() ON UPDATE current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `orders`
--

INSERT INTO `orders` (`orderId`, `userId`, `bookingId`, `restaurantId`, `totalAmount`, `status`, `createdAt`, `updatedAt`) VALUES
(6, 2, 12, 8, 2000, 'pending', '2024-11-23 07:32:55', '2024-12-15 13:49:40'),
(7, 10, 12, 8, 2000, 'sdjh', '2024-12-14 10:31:46', '2024-12-14 10:31:46'),
(8, 2, 12, 15, 1500, 'Done', '2024-12-15 13:49:40', '2024-12-15 13:49:40'),
(9, 2, 12, 8, 2000, 'ok', '2024-12-22 04:53:46', '2024-12-22 04:53:46'),
(10, 2, 12, 8, 2000, 'ok', '2024-12-22 04:54:55', '2024-12-22 04:54:55'),
(11, 12, 46, 13, 600, 'confirmed', '2024-12-22 06:48:12', '2024-12-22 06:48:12'),
(12, 12, 46, 13, 300, 'confirmed', '2024-12-22 07:05:46', '2024-12-22 07:05:46'),
(13, 12, 46, 13, 900, 'confirmed', '2024-12-22 07:07:13', '2024-12-22 07:07:13'),
(14, 12, 48, 13, 600, 'confirmed', '2024-12-22 08:03:22', '2024-12-22 08:03:22'),
(15, 12, 48, 13, 1200, 'confirmed', '2024-12-22 08:30:09', '2024-12-22 08:30:09'),
(16, 12, 49, 8, 1400, 'confirmed', '2024-12-22 08:33:09', '2024-12-22 08:33:09'),
(17, 12, 49, 8, 449, 'confirmed', '2024-12-22 08:48:17', '2024-12-22 08:48:17'),
(18, 12, 49, 8, 650, 'confirmed', '2024-12-22 08:51:59', '2024-12-22 08:51:59'),
(19, 12, 49, 8, 150, 'confirmed', '2024-12-22 08:57:10', '2024-12-22 08:57:10'),
(20, 12, 49, 8, 500, 'confirmed', '2024-12-22 08:59:56', '2024-12-22 08:59:56'),
(21, 12, 49, 8, 200, 'confirmed', '2024-12-22 09:32:55', '2024-12-22 09:32:55'),
(22, 12, 49, 8, 200, 'confirmed', '2024-12-22 09:33:56', '2024-12-22 09:33:56'),
(23, 12, 49, 8, 1150, 'confirmed', '2024-12-22 09:51:41', '2024-12-22 09:51:41'),
(24, 20, 52, 13, 798, 'confirmed', '2024-12-23 08:44:11', '2024-12-23 08:44:11'),
(25, 20, 52, 13, 798, 'confirmed', '2024-12-23 08:46:05', '2024-12-23 08:46:05'),
(26, 12, 53, 35, 250, 'confirmed', '2024-12-23 18:08:12', '2024-12-23 18:08:12'),
(27, 12, 55, 35, 1540, 'confirmed', '2024-12-24 08:26:20', '2024-12-24 08:26:20'),
(28, 12, 56, 8, 1099, 'confirmed', '2024-12-25 10:33:03', '2024-12-25 10:33:03'),
(29, 19, 71, 37, 240, 'confirmed', '2024-12-25 14:59:38', '2024-12-25 14:59:38');

-- --------------------------------------------------------

--
-- Table structure for table `restaurantphotos`
--

CREATE TABLE `restaurantphotos` (
  `photoId` int(100) NOT NULL,
  `restaurantId` int(100) NOT NULL,
  `photo` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `restaurantphotos`
--

INSERT INTO `restaurantphotos` (`photoId`, `restaurantId`, `photo`) VALUES
(11, 8, 'IMG_629496914425photo2.jpeg'),
(12, 13, 'IMG_316289609871restaurant.jpeg'),
(13, 15, 'Rest1.jpg'),
(14, 17, 'Rest2.jpg'),
(15, 18, 'Rest3.jpeg'),
(16, 28, 'Rest9.jpeg'),
(17, 32, 'IMG_496447675123Rest5.jpg'),
(18, 35, 'IMG_554849091821Rest6.jpg'),
(19, 34, 'madeovergrils.jpg'),
(20, 37, 'IMG_773427899991Rest2.jpg'),
(21, 34, 'madeovergrils2.jpg'),
(22, 34, 'madeovergrils3.jpg'),
(23, 34, 'madeovergrils4.jpg'),
(24, 34, 'madeovergrils5.jpg');

-- --------------------------------------------------------

--
-- Table structure for table `restaurants`
--

CREATE TABLE `restaurants` (
  `restaurantId` int(100) NOT NULL,
  `userId` int(100) NOT NULL,
  `cityId` int(100) NOT NULL,
  `stateId` int(100) NOT NULL,
  `restaurantName` varchar(100) NOT NULL,
  `address` varchar(500) NOT NULL,
  `pincode` varchar(100) NOT NULL,
  `phoneNo` varchar(100) NOT NULL,
  `website` varchar(100) NOT NULL,
  `email` varchar(100) NOT NULL,
  `openingTime` time NOT NULL,
  `closingTime` time NOT NULL,
  `createdAt` timestamp NOT NULL DEFAULT current_timestamp(),
  `updatedAt` timestamp NOT NULL DEFAULT current_timestamp() ON UPDATE current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `restaurants`
--

INSERT INTO `restaurants` (`restaurantId`, `userId`, `cityId`, `stateId`, `restaurantName`, `address`, `pincode`, `phoneNo`, `website`, `email`, `openingTime`, `closingTime`, `createdAt`, `updatedAt`) VALUES
(8, 2, 1, 2, 'kathiyawadi', 'Singanpore, Causeway Rd, near D Mart, Singanpor, Surat, Gujarat 395004', '360005', '+91 9924578548', 'www.kathiyawadi.com', 'kathiyawadi@gmail.com', '09:00:44', '18:00:44', '2024-11-23 07:27:38', '2024-12-25 16:40:34'),
(13, 14, 7, 4, 'Ganesh', 'Songada-Surat Road, Udhana Darwaja, Aman Nagar, Surat, Gujarat 395008', '123456', '+91 9054878455', 'www.ganesh.com', 'sfdf', '23:12:01', '23:12:01', '2024-12-14 13:03:51', '2024-12-25 16:43:00'),
(15, 31, 1, 2, 'Aashish', '5R2F+4X4, road, near Dmart, Jay Jawan Jay Kisan Nagar, Gopal Nagar Society, Pandesara, Udhana, Surat, Gujarat 394221', '999999', '+91 7045896515', 'www.aashish.com', 'ashish@gmail.com', '09:55:00', '21:00:00', '2024-12-14 13:14:39', '2024-12-25 16:43:10'),
(17, 2, 1, 2, 'Spice Villa Restaurant', 'Dumas Road, Piplod Behind Iscon Mall, Surat 395007 India\n', '123456', '+91 8547849658', 'http://spicevilla.com', 'spice@gmail.com', '23:12:01', '23:12:01', '2024-12-15 03:00:10', '2024-12-25 16:43:32'),
(18, 10, 7, 4, 'Vintage Asia', 'Surat Marriott Hotel Near Ambikaniketan', '123456', '+92 4847958254', 'http://vintageasia.com', 'vintageasia@gmail.com', '23:12:01', '23:12:01', '2024-12-15 13:55:06', '2024-12-25 16:43:40'),
(28, 10, 1, 2, 'Tulsi', 'Raj Mandir Farm, Uttran, opp. Maharaja Farm, near D-Mart, Mota Varachha, Surat, Gujarat 394105', '123456', '+92 9547854765', 'http://tulsirestaurant.com', 'tulsi@gmail.com', '09:00:00', '21:00:00', '2024-12-21 09:02:28', '2024-12-25 16:41:29'),
(32, 14, 1, 2, 'Lumina', 'Gujarati, North, Indian, Street Food\nNanpura, Surat', '395004', '+93 584954785', 'www.lumina.com', 'dhruvivavadiya01@gmail.com', '03:14:10', '05:32:00', '2024-12-23 09:00:09', '2024-12-25 16:43:19'),
(34, 10, 10, 2, 'Mad over grills', 'Bus Station, F-1Amenity Center, Nr, Udhana Main Rd, Jeevan Jyothi Nagar, Udhana, Surat, Gujarat 3942', '563454', '+91 9979454558', 'http://madeovergrills123.com', 'made_over_grils@gmail.com', '03:32:00', '03:16:27', '2024-12-23 09:37:08', '2024-12-25 16:55:27'),
(35, 14, 1, 2, 'Comfy Cravings', '25, Rander Rd, Shree Rang Society, Dwarkadhis Society, Palanpur Patia, Surat, Gujarat 395009', '584785', '+61 5864455487', 'http://comfy craving.com', 'comfy@gmail.com', '02:00:00', '05:15:14', '2024-12-23 17:48:07', '2024-12-25 16:44:04'),
(37, 31, 10, 2, 'maheshpavbhaji', '03,sundayhub,ambatalavdi,surat', '395004', '+91 5847856285', 'http://maheshbhaji.com', 'xdftgyujiokedrtfg', '09:00:00', '11:00:00', '2024-12-25 14:49:53', '2024-12-25 16:44:12');

-- --------------------------------------------------------

--
-- Table structure for table `restauranttables`
--

CREATE TABLE `restauranttables` (
  `tableId` int(100) NOT NULL,
  `restaurantId` int(100) NOT NULL,
  `tableNo` int(100) NOT NULL,
  `seatingCapacity` int(100) NOT NULL,
  `status` varchar(100) NOT NULL,
  `createdAt` timestamp NOT NULL DEFAULT current_timestamp(),
  `updatedAt` timestamp NOT NULL DEFAULT current_timestamp() ON UPDATE current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `restauranttables`
--

INSERT INTO `restauranttables` (`tableId`, `restaurantId`, `tableNo`, `seatingCapacity`, `status`, `createdAt`, `updatedAt`) VALUES
(16, 8, 1, 10, 'reserved', '2024-11-23 07:28:32', '2024-12-25 18:04:41'),
(18, 13, 8, 10, 'reserved', '2024-12-15 14:02:28', '2024-12-22 05:39:28'),
(19, 34, 44, 10, 'available', '2024-12-22 05:39:09', '2024-12-25 17:50:45'),
(24, 37, 5, 10, 'available', '2024-12-25 14:50:33', '2024-12-25 17:50:50');

-- --------------------------------------------------------

--
-- Table structure for table `restaurant_cuisine`
--

CREATE TABLE `restaurant_cuisine` (
  `restaurantId` int(100) NOT NULL,
  `cuisineId` int(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `restaurant_cuisine`
--

INSERT INTO `restaurant_cuisine` (`restaurantId`, `cuisineId`) VALUES
(8, 2),
(8, 1),
(8, 3),
(18, 2),
(17, 2),
(15, 3),
(28, 2),
(28, 3),
(32, 1),
(32, 3),
(34, 1),
(34, 2),
(13, 3),
(13, 1),
(13, 2),
(8, 2),
(8, 1),
(8, 3),
(18, 2),
(17, 2),
(15, 3),
(28, 2),
(28, 3),
(32, 1),
(32, 3),
(34, 1),
(34, 2),
(13, 3),
(13, 1),
(13, 2),
(37, 3),
(37, 2),
(37, 1);

-- --------------------------------------------------------

--
-- Table structure for table `reviews`
--

CREATE TABLE `reviews` (
  `reviewId` int(100) NOT NULL,
  `userId` int(100) NOT NULL,
  `restaurantId` int(100) NOT NULL,
  `comment` varchar(500) NOT NULL,
  `rating` int(100) NOT NULL,
  `createdAt` timestamp NOT NULL DEFAULT current_timestamp(),
  `updatedAt` timestamp NOT NULL DEFAULT current_timestamp() ON UPDATE current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `reviews`
--

INSERT INTO `reviews` (`reviewId`, `userId`, `restaurantId`, `comment`, `rating`, `createdAt`, `updatedAt`) VALUES
(13, 2, 13, 'Ganesh restaurant is Great restaurant', 3, '2024-12-19 06:11:54', '2024-12-19 06:11:54'),
(14, 2, 13, 'abcdf...', 5, '2024-12-22 12:50:04', '2024-12-22 12:50:04'),
(15, 2, 13, 'abcdf...', 5, '2024-12-22 12:50:08', '2024-12-22 12:50:08'),
(16, 2, 13, 'abcdf...', 5, '2024-12-22 12:50:13', '2024-12-22 12:50:13'),
(17, 2, 35, 'It\'s great restaurant', 3, '2024-12-23 18:10:08', '2024-12-23 18:10:08'),
(18, 2, 8, 'Amazing food made even better by the excellent service! Elle and Jaz were amazing and gave us the be', 4, '2024-12-24 02:45:12', '2024-12-24 02:45:12'),
(19, 2, 37, 'mst', 3, '2024-12-25 15:01:26', '2024-12-25 15:01:26');

-- --------------------------------------------------------

--
-- Table structure for table `states`
--

CREATE TABLE `states` (
  `stateId` int(100) NOT NULL,
  `stateName` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `states`
--

INSERT INTO `states` (`stateId`, `stateName`) VALUES
(2, 'Gujarat'),
(4, 'Maharashtra');

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE `users` (
  `userId` int(100) NOT NULL,
  `groupId` int(100) NOT NULL,
  `userName` varchar(100) NOT NULL,
  `email` varchar(100) NOT NULL,
  `password` varchar(500) NOT NULL,
  `phoneNo` varchar(100) NOT NULL,
  `createdAt` timestamp NOT NULL DEFAULT current_timestamp(),
  `updatedAt` timestamp NOT NULL DEFAULT current_timestamp() ON UPDATE current_timestamp(),
  `status` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`userId`, `groupId`, `userName`, `email`, `password`, `phoneNo`, `createdAt`, `updatedAt`, `status`) VALUES
(2, 2, 'priyanka', 'priyanka@gmail.com', 'PBKDF2WithHmacSHA256:2048:setjQvVtcfGDgJw8pgmbOPBWPqKjmJSaVXpEnfR6jhY=:MKIcAN9nYkARN9OZiSMBPCELv4E0T1KSTIvepgLFpwk=', '1234567', '2024-10-29 09:28:30', '2024-12-25 15:30:22', 'active'),
(10, 2, 'dhruvi', 'dhruvi@gmail.com', 'PBKDF2WithHmacSHA256:2048:setjQvVtcfGDgJw8pgmbOPBWPqKjmJSaVXpEnfR6jhY=:MKIcAN9nYkARN9OZiSMBPCELv4E0T1KSTIvepgLFpwk=', '1234567890', '2024-11-07 11:18:17', '2024-12-25 16:27:14', 'active'),
(11, 3, 'admin', 'admin@gmail.com', 'PBKDF2WithHmacSHA256:2048:uS4W774WdYj872LVuRSMujHdgqEVf7yPGZw6MGbgKI8=:VVT3CD1wfVvkQ7ct2eCNWUKr6GuMFztvJPOUgD1MybU=', '1234567890', '2024-11-13 12:25:00', '2024-12-25 15:28:35', 'active'),
(12, 1, 'user', 'user@gmail.com', 'PBKDF2WithHmacSHA256:2048:ooL0ULgBf6Fq0YurXBIKMjWWrqOukulRBqAXzFjExys=:Gh8g16d69tWZVltJVRc17GweywmXVr1+eTl7FyKgdxQ=', '1234567890', '2024-12-15 13:39:51', '2024-12-25 15:28:31', 'active'),
(14, 2, 'dhruv', 'dhruv@gmail.com', 'PBKDF2WithHmacSHA256:2048:setjQvVtcfGDgJw8pgmbOPBWPqKjmJSaVXpEnfR6jhY=:MKIcAN9nYkARN9OZiSMBPCELv4E0T1KSTIvepgLFpwk=', '1234456789', '2024-12-15 13:47:09', '2024-12-25 15:29:54', 'active'),
(19, 1, 'nency', 'nency@gmail.com', 'PBKDF2WithHmacSHA256:2048:ooL0ULgBf6Fq0YurXBIKMjWWrqOukulRBqAXzFjExys=:Gh8g16d69tWZVltJVRc17GweywmXVr1+eTl7FyKgdxQ=', '70487 94595', '2024-12-22 14:21:11', '2024-12-25 15:28:46', 'active'),
(20, 1, 'janu', 'janu@gmail.com', 'PBKDF2WithHmacSHA256:2048:ooL0ULgBf6Fq0YurXBIKMjWWrqOukulRBqAXzFjExys=:Gh8g16d69tWZVltJVRc17GweywmXVr1+eTl7FyKgdxQ=', '70487 94595', '2024-12-23 08:39:46', '2024-12-25 15:17:12', 'active'),
(31, 2, 'mahesh', 'maheshbhai@gmail.com', 'PBKDF2WithHmacSHA256:2048:KtSe/WD3r3DUkQXAKllclSqFq5vJ+Mw5INMiNkRrmmA=:uYbQ/h2UMtV3ksIF65WGM5aFPju2zRVAJaoAynuX4eQ=', '99257 08901', '2024-12-25 14:47:01', '2024-12-25 14:47:01', 'active'),
(32, 1, 'janvi', 'janvi@gmail.com', 'PBKDF2WithHmacSHA256:2048:tDzzUezd1L7MfYIlaMdbNXG6gz3bHcAfHn+ZoJTXIlc=:bPdUiCpij3Nzg4ZOougRBHJOcH8kAaXsLv/4ZO5ovL8=', '85484 98544', '2024-12-25 17:38:25', '2024-12-25 17:38:25', 'active');

-- --------------------------------------------------------

--
-- Table structure for table `user_orderitem`
--

CREATE TABLE `user_orderitem` (
  `userId` int(100) NOT NULL,
  `orderItemId` int(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `user_orderitem`
--

INSERT INTO `user_orderitem` (`userId`, `orderItemId`) VALUES
(12, 24),
(12, 25),
(20, 26),
(20, 27),
(12, 28),
(12, 29),
(12, 30),
(12, 31),
(12, 32),
(12, 33),
(12, 24),
(12, 25),
(20, 26),
(20, 27),
(12, 28),
(12, 29),
(12, 30),
(12, 31),
(12, 32),
(12, 33),
(19, 34);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `bookings`
--
ALTER TABLE `bookings`
  ADD PRIMARY KEY (`bookingId`),
  ADD KEY `userId` (`userId`),
  ADD KEY `restaurantId` (`restaurantId`);

--
-- Indexes for table `cities`
--
ALTER TABLE `cities`
  ADD PRIMARY KEY (`cityId`),
  ADD KEY `stateId` (`stateId`);

--
-- Indexes for table `contact`
--
ALTER TABLE `contact`
  ADD PRIMARY KEY (`contactid`),
  ADD KEY `fk_constraint_name` (`userId`);

--
-- Indexes for table `cuisinetype`
--
ALTER TABLE `cuisinetype`
  ADD PRIMARY KEY (`cuisineId`);

--
-- Indexes for table `groupmaster`
--
ALTER TABLE `groupmaster`
  ADD PRIMARY KEY (`groupId`),
  ADD UNIQUE KEY `userName` (`userName`);

--
-- Indexes for table `menuitems`
--
ALTER TABLE `menuitems`
  ADD PRIMARY KEY (`itemId`),
  ADD KEY `restaurantId` (`restaurantId`);

--
-- Indexes for table `multipletablebooking`
--
ALTER TABLE `multipletablebooking`
  ADD PRIMARY KEY (`multiTableId`),
  ADD KEY `bookingId` (`bookingId`),
  ADD KEY `tableId` (`tableId`);

--
-- Indexes for table `orderitems`
--
ALTER TABLE `orderitems`
  ADD PRIMARY KEY (`orderItemId`),
  ADD KEY `orderId` (`orderId`),
  ADD KEY `itemId` (`itemId`);

--
-- Indexes for table `orders`
--
ALTER TABLE `orders`
  ADD PRIMARY KEY (`orderId`),
  ADD KEY `bookingId` (`bookingId`),
  ADD KEY `restaurantId` (`restaurantId`),
  ADD KEY `userId` (`userId`);

--
-- Indexes for table `restaurantphotos`
--
ALTER TABLE `restaurantphotos`
  ADD PRIMARY KEY (`photoId`),
  ADD KEY `restaurantId` (`restaurantId`);

--
-- Indexes for table `restaurants`
--
ALTER TABLE `restaurants`
  ADD PRIMARY KEY (`restaurantId`),
  ADD KEY `userId` (`userId`),
  ADD KEY `cityId` (`cityId`),
  ADD KEY `stateId` (`stateId`);

--
-- Indexes for table `restauranttables`
--
ALTER TABLE `restauranttables`
  ADD PRIMARY KEY (`tableId`),
  ADD UNIQUE KEY `tableNo` (`tableNo`),
  ADD KEY `restaurantId` (`restaurantId`);

--
-- Indexes for table `restaurant_cuisine`
--
ALTER TABLE `restaurant_cuisine`
  ADD KEY `restaurantId` (`restaurantId`),
  ADD KEY `cuisineId` (`cuisineId`);

--
-- Indexes for table `reviews`
--
ALTER TABLE `reviews`
  ADD PRIMARY KEY (`reviewId`),
  ADD KEY `userId` (`userId`),
  ADD KEY `restaurantId` (`restaurantId`);

--
-- Indexes for table `states`
--
ALTER TABLE `states`
  ADD PRIMARY KEY (`stateId`);

--
-- Indexes for table `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`userId`),
  ADD UNIQUE KEY `userName` (`userName`),
  ADD UNIQUE KEY `email` (`email`),
  ADD KEY `groupId` (`groupId`);

--
-- Indexes for table `user_orderitem`
--
ALTER TABLE `user_orderitem`
  ADD KEY `userId` (`userId`),
  ADD KEY `orderItemId` (`orderItemId`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `bookings`
--
ALTER TABLE `bookings`
  MODIFY `bookingId` int(100) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=77;

--
-- AUTO_INCREMENT for table `cities`
--
ALTER TABLE `cities`
  MODIFY `cityId` int(100) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=15;

--
-- AUTO_INCREMENT for table `cuisinetype`
--
ALTER TABLE `cuisinetype`
  MODIFY `cuisineId` int(100) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT for table `groupmaster`
--
ALTER TABLE `groupmaster`
  MODIFY `groupId` int(100) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=21;

--
-- AUTO_INCREMENT for table `menuitems`
--
ALTER TABLE `menuitems`
  MODIFY `itemId` int(100) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=47;

--
-- AUTO_INCREMENT for table `multipletablebooking`
--
ALTER TABLE `multipletablebooking`
  MODIFY `multiTableId` int(100) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=71;

--
-- AUTO_INCREMENT for table `orderitems`
--
ALTER TABLE `orderitems`
  MODIFY `orderItemId` int(100) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=35;

--
-- AUTO_INCREMENT for table `orders`
--
ALTER TABLE `orders`
  MODIFY `orderId` int(100) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=30;

--
-- AUTO_INCREMENT for table `restaurantphotos`
--
ALTER TABLE `restaurantphotos`
  MODIFY `photoId` int(100) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=25;

--
-- AUTO_INCREMENT for table `restaurants`
--
ALTER TABLE `restaurants`
  MODIFY `restaurantId` int(100) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=38;

--
-- AUTO_INCREMENT for table `restauranttables`
--
ALTER TABLE `restauranttables`
  MODIFY `tableId` int(100) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=25;

--
-- AUTO_INCREMENT for table `reviews`
--
ALTER TABLE `reviews`
  MODIFY `reviewId` int(100) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=20;

--
-- AUTO_INCREMENT for table `states`
--
ALTER TABLE `states`
  MODIFY `stateId` int(100) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT for table `users`
--
ALTER TABLE `users`
  MODIFY `userId` int(100) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=33;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `bookings`
--
ALTER TABLE `bookings`
  ADD CONSTRAINT `bookings_ibfk_2` FOREIGN KEY (`userId`) REFERENCES `users` (`userId`),
  ADD CONSTRAINT `bookings_ibfk_3` FOREIGN KEY (`restaurantId`) REFERENCES `restaurants` (`restaurantId`);

--
-- Constraints for table `cities`
--
ALTER TABLE `cities`
  ADD CONSTRAINT `cities_ibfk_1` FOREIGN KEY (`stateId`) REFERENCES `states` (`stateId`);

--
-- Constraints for table `contact`
--
ALTER TABLE `contact`
  ADD CONSTRAINT `contact_ibfk_1` FOREIGN KEY (`userId`) REFERENCES `users` (`userId`),
  ADD CONSTRAINT `fk_constraint_name` FOREIGN KEY (`userId`) REFERENCES `users` (`userId`);

--
-- Constraints for table `menuitems`
--
ALTER TABLE `menuitems`
  ADD CONSTRAINT `menuitems_ibfk_1` FOREIGN KEY (`restaurantId`) REFERENCES `restaurants` (`restaurantId`);

--
-- Constraints for table `multipletablebooking`
--
ALTER TABLE `multipletablebooking`
  ADD CONSTRAINT `multipletablebooking_ibfk_1` FOREIGN KEY (`bookingId`) REFERENCES `bookings` (`bookingId`),
  ADD CONSTRAINT `multipletablebooking_ibfk_2` FOREIGN KEY (`tableId`) REFERENCES `restauranttables` (`tableId`);

--
-- Constraints for table `orderitems`
--
ALTER TABLE `orderitems`
  ADD CONSTRAINT `orderitems_ibfk_1` FOREIGN KEY (`orderId`) REFERENCES `orders` (`orderId`),
  ADD CONSTRAINT `orderitems_ibfk_2` FOREIGN KEY (`itemId`) REFERENCES `menuitems` (`itemId`);

--
-- Constraints for table `orders`
--
ALTER TABLE `orders`
  ADD CONSTRAINT `orders_ibfk_1` FOREIGN KEY (`bookingId`) REFERENCES `bookings` (`bookingId`),
  ADD CONSTRAINT `orders_ibfk_2` FOREIGN KEY (`restaurantId`) REFERENCES `restaurants` (`restaurantId`),
  ADD CONSTRAINT `orders_ibfk_4` FOREIGN KEY (`userId`) REFERENCES `users` (`userId`);

--
-- Constraints for table `restaurantphotos`
--
ALTER TABLE `restaurantphotos`
  ADD CONSTRAINT `restaurantphotos_ibfk_1` FOREIGN KEY (`restaurantId`) REFERENCES `restaurants` (`restaurantId`);

--
-- Constraints for table `restaurants`
--
ALTER TABLE `restaurants`
  ADD CONSTRAINT `restaurants_ibfk_1` FOREIGN KEY (`userId`) REFERENCES `users` (`userId`),
  ADD CONSTRAINT `restaurants_ibfk_2` FOREIGN KEY (`cityId`) REFERENCES `cities` (`cityId`),
  ADD CONSTRAINT `restaurants_ibfk_3` FOREIGN KEY (`stateId`) REFERENCES `states` (`stateId`);

--
-- Constraints for table `restauranttables`
--
ALTER TABLE `restauranttables`
  ADD CONSTRAINT `restauranttables_ibfk_1` FOREIGN KEY (`restaurantId`) REFERENCES `restaurants` (`restaurantId`);

--
-- Constraints for table `restaurant_cuisine`
--
ALTER TABLE `restaurant_cuisine`
  ADD CONSTRAINT `restaurant_cuisine_ibfk_1` FOREIGN KEY (`restaurantId`) REFERENCES `restaurants` (`restaurantId`),
  ADD CONSTRAINT `restaurant_cuisine_ibfk_2` FOREIGN KEY (`cuisineId`) REFERENCES `cuisinetype` (`cuisineId`);

--
-- Constraints for table `reviews`
--
ALTER TABLE `reviews`
  ADD CONSTRAINT `reviews_ibfk_1` FOREIGN KEY (`userId`) REFERENCES `users` (`userId`),
  ADD CONSTRAINT `reviews_ibfk_2` FOREIGN KEY (`restaurantId`) REFERENCES `restaurants` (`restaurantId`);

--
-- Constraints for table `users`
--
ALTER TABLE `users`
  ADD CONSTRAINT `users_ibfk_1` FOREIGN KEY (`groupId`) REFERENCES `groupmaster` (`groupId`);

--
-- Constraints for table `user_orderitem`
--
ALTER TABLE `user_orderitem`
  ADD CONSTRAINT `user_orderitem_ibfk_1` FOREIGN KEY (`userId`) REFERENCES `users` (`userId`),
  ADD CONSTRAINT `user_orderitem_ibfk_2` FOREIGN KEY (`orderItemId`) REFERENCES `orderitems` (`orderItemId`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
