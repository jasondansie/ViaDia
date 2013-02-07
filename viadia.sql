-- phpMyAdmin SQL Dump
-- version 3.5.2.2
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: Feb 07, 2013 at 05:30 PM
-- Server version: 5.5.27
-- PHP Version: 5.4.7

SET SQL_MODE="NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `viadia`
--

DELIMITER $$
--
-- Procedures
--
CREATE DEFINER=`root`@`localhost` PROCEDURE `test_multi_sets`()
    DETERMINISTIC
begin
        select user() as first_col;
        select user() as first_col, now() as second_col;
        select user() as first_col, now() as second_col, now() as third_col;
        end$$

DELIMITER ;

-- --------------------------------------------------------

--
-- Table structure for table `april`
--

CREATE TABLE IF NOT EXISTS `april` (
  `id` int(20) NOT NULL AUTO_INCREMENT,
  `Table_num` int(11) NOT NULL,
  `Reserver_name` varchar(50) NOT NULL,
  `Email` varchar(55) NOT NULL,
  `Phone_num` int(14) NOT NULL,
  `Begin_date` date NOT NULL,
  `End_date` date NOT NULL,
  `Editor_Name` varchar(50) NOT NULL,
  `Reserved` int(5) NOT NULL,
  `week_num` int(11) NOT NULL,
  `comments` text NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=7 ;

--
-- Dumping data for table `april`
--

INSERT INTO `april` (`id`, `Table_num`, `Reserver_name`, `Email`, `Phone_num`, `Begin_date`, `End_date`, `Editor_Name`, `Reserved`, `week_num`, `comments`) VALUES
(3, 39, 'jasdfkjöf', 'fasdfasdfad', 2147483647, '2013-01-31', '2013-02-09', 'dasar', 1, 0, ''),
(5, 2, 'jane', 'jane@hel', 2345563, '2013-01-25', '2013-01-25', 'dasar', 1, 0, ''),
(6, 28, 'jgkjh', 'gyigy', 7697856, '2013-04-01', '2013-04-01', 'jason', 1, 0, '');

-- --------------------------------------------------------

--
-- Table structure for table `august`
--

CREATE TABLE IF NOT EXISTS `august` (
  `id` int(20) NOT NULL AUTO_INCREMENT,
  `Table_num` int(11) NOT NULL,
  `Reserver_name` varchar(50) NOT NULL,
  `Email` varchar(55) NOT NULL,
  `Phone_num` int(14) NOT NULL,
  `Begin_date` date NOT NULL,
  `End_date` date NOT NULL,
  `Editor_Name` varchar(50) NOT NULL,
  `Reserved` int(5) NOT NULL,
  `week_num` int(3) NOT NULL,
  `comments` text NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=6 ;

--
-- Dumping data for table `august`
--

INSERT INTO `august` (`id`, `Table_num`, `Reserver_name`, `Email`, `Phone_num`, `Begin_date`, `End_date`, `Editor_Name`, `Reserved`, `week_num`, `comments`) VALUES
(1, 34, 'jason', 'jack@joe.com', 405768767, '2013-02-07', '2013-02-14', 'jaond', 1, 0, ''),
(3, 39, 'jasdfkjöf', 'fasdfasdfad', 2147483647, '2013-01-31', '2013-02-09', 'dasar', 1, 0, ''),
(4, 59, 'jack', 'j@g.com', 345345456, '2013-02-06', '2013-02-13', 'jason', 1, 0, ''),
(5, 2, 'jane', 'jane@hel', 2345563, '2013-01-25', '2013-01-25', 'dasar', 1, 0, '');

-- --------------------------------------------------------

--
-- Table structure for table `december`
--

CREATE TABLE IF NOT EXISTS `december` (
  `id` int(20) NOT NULL AUTO_INCREMENT,
  `Table_num` int(11) NOT NULL,
  `Reserver_name` varchar(50) NOT NULL,
  `Email` varchar(55) NOT NULL,
  `Phone_num` int(14) NOT NULL,
  `Begin_date` date NOT NULL,
  `End_date` date NOT NULL,
  `Editor_Name` varchar(50) NOT NULL,
  `Reserved` int(5) NOT NULL,
  `week_num` int(3) NOT NULL,
  `comments` text NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=6 ;

--
-- Dumping data for table `december`
--

INSERT INTO `december` (`id`, `Table_num`, `Reserver_name`, `Email`, `Phone_num`, `Begin_date`, `End_date`, `Editor_Name`, `Reserved`, `week_num`, `comments`) VALUES
(1, 34, 'jason', 'jack@joe.com', 405768767, '2013-02-07', '2013-02-14', 'jaond', 1, 0, ''),
(3, 39, 'jasdfkjöf', 'fasdfasdfad', 2147483647, '2013-01-31', '2013-02-09', 'dasar', 1, 0, ''),
(4, 59, 'jack', 'j@g.com', 345345456, '2013-02-06', '2013-02-13', 'jason', 1, 0, ''),
(5, 2, 'jane', 'jane@hel', 2345563, '2013-01-25', '2013-01-25', 'dasar', 1, 0, '');

-- --------------------------------------------------------

--
-- Table structure for table `february`
--

CREATE TABLE IF NOT EXISTS `february` (
  `id` int(20) NOT NULL AUTO_INCREMENT,
  `Table_num` int(11) NOT NULL,
  `Reserver_name` varchar(50) NOT NULL,
  `Email` varchar(55) NOT NULL,
  `Phone_num` int(14) NOT NULL,
  `Begin_date` date NOT NULL,
  `End_date` date NOT NULL,
  `Editor_Name` varchar(50) NOT NULL,
  `Reserved` int(5) NOT NULL,
  `week_num` int(3) NOT NULL,
  `comments` text NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=8 ;

--
-- Dumping data for table `february`
--

INSERT INTO `february` (`id`, `Table_num`, `Reserver_name`, `Email`, `Phone_num`, `Begin_date`, `End_date`, `Editor_Name`, `Reserved`, `week_num`, `comments`) VALUES
(1, 34, 'jason', 'jack@joe.com', 405768767, '2013-02-07', '2013-02-14', 'jaond', 1, 0, ''),
(3, 39, 'jasdfkjöf', 'fasdfasdfad', 2147483647, '2013-01-31', '2013-02-09', 'dasar', 1, 0, ''),
(4, 59, 'jack', 'j@g.com', 345345456, '2013-02-06', '2013-02-13', 'jason', 1, 0, ''),
(5, 2, 'jane', 'jane@hel', 2345563, '2013-01-25', '2013-02-14', 'dasar', 1, 0, ''),
(6, 8, 'test2', 'asdfasf', 33, '2013-02-04', '2013-02-17', 'jöfj', 1, 2, ''),
(7, 16, 'jasdon', 'jalsdfj', 234567, '2013-02-07', '2013-02-27', 'sgsfdg', 1, 3, '');

-- --------------------------------------------------------

--
-- Table structure for table `january`
--

CREATE TABLE IF NOT EXISTS `january` (
  `id` int(20) NOT NULL AUTO_INCREMENT,
  `Table_num` int(11) NOT NULL,
  `Reserver_name` varchar(50) NOT NULL,
  `Email` varchar(55) NOT NULL,
  `Phone_num` int(14) NOT NULL,
  `Begin_date` date NOT NULL,
  `End_date` date NOT NULL,
  `Editor_Name` varchar(50) NOT NULL,
  `Reserved` int(5) NOT NULL,
  `week_num` int(3) NOT NULL,
  `comments` text NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=6 ;

--
-- Dumping data for table `january`
--

INSERT INTO `january` (`id`, `Table_num`, `Reserver_name`, `Email`, `Phone_num`, `Begin_date`, `End_date`, `Editor_Name`, `Reserved`, `week_num`, `comments`) VALUES
(1, 34, 'jason', 'jack@joe.com', 405768767, '2013-02-07', '2013-02-14', 'jaond', 1, 0, ''),
(3, 39, 'jasdfkjöf', 'fasdfasdfad', 2147483647, '2013-01-31', '2013-02-09', 'dasar', 1, 0, ''),
(4, 59, 'jack', 'j@g.com', 345345456, '2013-02-06', '2013-02-13', 'jason', 1, 0, ''),
(5, 2, 'jane', 'jane@hel', 2345563, '2013-01-25', '2013-01-25', 'dasar', 1, 0, '');

-- --------------------------------------------------------

--
-- Table structure for table `july`
--

CREATE TABLE IF NOT EXISTS `july` (
  `id` int(20) NOT NULL AUTO_INCREMENT,
  `Table_num` int(11) NOT NULL,
  `Reserver_name` varchar(50) NOT NULL,
  `Email` varchar(55) NOT NULL,
  `Phone_num` int(14) NOT NULL,
  `Begin_date` date NOT NULL,
  `End_date` date NOT NULL,
  `Editor_Name` varchar(50) NOT NULL,
  `Reserved` int(5) NOT NULL,
  `week_num` int(3) NOT NULL,
  `comments` text NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=6 ;

--
-- Dumping data for table `july`
--

INSERT INTO `july` (`id`, `Table_num`, `Reserver_name`, `Email`, `Phone_num`, `Begin_date`, `End_date`, `Editor_Name`, `Reserved`, `week_num`, `comments`) VALUES
(1, 34, 'jason', 'jack@joe.com', 405768767, '2013-02-07', '2013-02-14', 'jaond', 1, 0, ''),
(3, 39, 'jasdfkjöf', 'fasdfasdfad', 2147483647, '2013-01-31', '2013-02-09', 'dasar', 1, 0, ''),
(4, 59, 'jack', 'j@g.com', 345345456, '2013-02-06', '2013-02-13', 'jason', 1, 0, ''),
(5, 2, 'jane', 'jane@hel', 2345563, '2013-01-25', '2013-01-25', 'dasar', 1, 0, '');

-- --------------------------------------------------------

--
-- Table structure for table `june`
--

CREATE TABLE IF NOT EXISTS `june` (
  `id` int(20) NOT NULL AUTO_INCREMENT,
  `Table_num` int(11) NOT NULL,
  `Reserver_name` varchar(50) NOT NULL,
  `Email` varchar(55) NOT NULL,
  `Phone_num` int(14) NOT NULL,
  `Begin_date` date NOT NULL,
  `End_date` date NOT NULL,
  `Editor_Name` varchar(50) NOT NULL,
  `Reserved` int(5) NOT NULL,
  `week_num` int(3) NOT NULL,
  `comments` text NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=5 ;

--
-- Dumping data for table `june`
--

INSERT INTO `june` (`id`, `Table_num`, `Reserver_name`, `Email`, `Phone_num`, `Begin_date`, `End_date`, `Editor_Name`, `Reserved`, `week_num`, `comments`) VALUES
(1, 34, 'jason', 'jack@joe.com', 405768767, '2013-02-07', '2013-02-14', 'jaond', 1, 0, ''),
(3, 70, 'jasdfkjöf', 'fasdfasdfad', 2147483647, '2013-01-31', '2013-02-09', 'dasar', 1, 0, ''),
(4, 59, 'jack', 'j@g.com', 345345456, '2013-02-06', '2013-02-13', 'jason', 1, 0, '');

-- --------------------------------------------------------

--
-- Table structure for table `march`
--

CREATE TABLE IF NOT EXISTS `march` (
  `id` int(20) NOT NULL AUTO_INCREMENT,
  `Table_num` int(11) NOT NULL,
  `Reserver_name` varchar(50) NOT NULL,
  `Email` varchar(55) NOT NULL,
  `Phone_num` int(14) NOT NULL,
  `Begin_date` date NOT NULL,
  `End_date` date NOT NULL,
  `Editor_Name` varchar(50) NOT NULL,
  `Reserved` int(5) NOT NULL,
  `week_num` int(3) NOT NULL,
  `comments` text NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=9 ;

--
-- Dumping data for table `march`
--

INSERT INTO `march` (`id`, `Table_num`, `Reserver_name`, `Email`, `Phone_num`, `Begin_date`, `End_date`, `Editor_Name`, `Reserved`, `week_num`, `comments`) VALUES
(1, 34, 'jason', 'jack@joe.com', 405768767, '2013-02-07', '2013-02-14', 'jaond', 1, 0, ''),
(3, 39, 'jasdfkjöf', 'fasdfasdfad', 2147483647, '2013-01-31', '2013-02-09', 'dasar', 1, 0, ''),
(4, 59, 'jack', 'j@g.com', 345345456, '2013-02-06', '2013-02-13', 'jason', 1, 0, ''),
(5, 2, 'jane', 'jane@hel', 2345563, '2013-01-25', '2013-01-25', 'dasar', 1, 0, ''),
(6, 54, 'kjljaösd', 'sdfa', 2342134, '2013-03-01', '2013-03-01', '123414', 1, 0, ''),
(7, 45, 'jason', 'sdfasdf', 5346367, '2013-03-01', '2013-03-01', 'jason', 1, 0, ''),
(8, 10, 'jack b nimble', 'jack@me.com', 242435243, '2013-03-01', '2013-03-14', 'jason', 1, 0, '');

-- --------------------------------------------------------

--
-- Table structure for table `may`
--

CREATE TABLE IF NOT EXISTS `may` (
  `id` int(20) NOT NULL AUTO_INCREMENT,
  `Table_num` int(11) NOT NULL,
  `Reserver_name` varchar(50) NOT NULL,
  `Email` varchar(55) NOT NULL,
  `Phone_num` int(14) NOT NULL,
  `Begin_date` date NOT NULL,
  `End_date` date NOT NULL,
  `Editor_Name` varchar(50) NOT NULL,
  `Reserved` int(5) NOT NULL,
  `week_num` int(3) NOT NULL,
  `comments` text NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=7 ;

--
-- Dumping data for table `may`
--

INSERT INTO `may` (`id`, `Table_num`, `Reserver_name`, `Email`, `Phone_num`, `Begin_date`, `End_date`, `Editor_Name`, `Reserved`, `week_num`, `comments`) VALUES
(1, 34, 'jason', 'jack@joe.com', 405768767, '2013-02-07', '2013-02-14', 'jaond', 1, 0, ''),
(3, 39, 'jasdfkjöf', 'fasdfasdfad', 2147483647, '2013-01-31', '2013-02-09', 'dasar', 1, 0, ''),
(4, 59, 'jack', 'j@g.com', 345345456, '2013-02-06', '2013-02-13', 'jason', 1, 0, ''),
(5, 2, 'jane', 'jane@hel', 2345563, '2013-01-25', '2013-01-25', 'dasar', 1, 0, ''),
(6, 8, 'jhgjgfhgdh', 'kjhx', 987654, '2013-05-01', '2013-05-01', 'jason', 1, 0, '');

-- --------------------------------------------------------

--
-- Table structure for table `november`
--

CREATE TABLE IF NOT EXISTS `november` (
  `id` int(20) NOT NULL AUTO_INCREMENT,
  `Table_num` int(11) NOT NULL,
  `Reserver_name` varchar(50) NOT NULL,
  `Email` varchar(55) NOT NULL,
  `Phone_num` int(14) NOT NULL,
  `Begin_date` date NOT NULL,
  `End_date` date NOT NULL,
  `Editor_Name` varchar(50) NOT NULL,
  `Reserved` int(5) NOT NULL,
  `week_num` int(3) NOT NULL,
  `comments` text NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=6 ;

--
-- Dumping data for table `november`
--

INSERT INTO `november` (`id`, `Table_num`, `Reserver_name`, `Email`, `Phone_num`, `Begin_date`, `End_date`, `Editor_Name`, `Reserved`, `week_num`, `comments`) VALUES
(1, 34, 'jason', 'jack@joe.com', 405768767, '2013-02-07', '2013-02-14', 'jaond', 1, 0, ''),
(3, 39, 'jasdfkjöf', 'fasdfasdfad', 2147483647, '2013-01-31', '2013-02-09', 'dasar', 1, 0, ''),
(4, 59, 'jack', 'j@g.com', 345345456, '2013-02-06', '2013-02-13', 'jason', 1, 0, ''),
(5, 2, 'jane', 'jane@hel', 2345563, '2013-01-25', '2013-01-25', 'dasar', 1, 0, '');

-- --------------------------------------------------------

--
-- Table structure for table `october`
--

CREATE TABLE IF NOT EXISTS `october` (
  `id` int(20) NOT NULL AUTO_INCREMENT,
  `Table_num` int(11) NOT NULL,
  `Reserver_name` varchar(50) NOT NULL,
  `Email` varchar(55) NOT NULL,
  `Phone_num` int(14) NOT NULL,
  `Begin_date` date NOT NULL,
  `End_date` date NOT NULL,
  `Editor_Name` varchar(50) NOT NULL,
  `Reserved` int(5) NOT NULL,
  `week_num` int(3) NOT NULL,
  `comments` text NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=6 ;

--
-- Dumping data for table `october`
--

INSERT INTO `october` (`id`, `Table_num`, `Reserver_name`, `Email`, `Phone_num`, `Begin_date`, `End_date`, `Editor_Name`, `Reserved`, `week_num`, `comments`) VALUES
(1, 34, 'jason', 'jack@joe.com', 405768767, '2013-02-07', '2013-02-14', 'jaond', 1, 0, ''),
(3, 39, 'jasdfkjöf', 'fasdfasdfad', 2147483647, '2013-01-31', '2013-02-09', 'dasar', 1, 0, ''),
(4, 59, 'jack', 'j@g.com', 345345456, '2013-02-06', '2013-02-13', 'jason', 1, 0, ''),
(5, 2, 'jane', 'jane@hel', 2345563, '2013-01-25', '2013-01-25', 'dasar', 1, 0, '');

-- --------------------------------------------------------

--
-- Table structure for table `savetable`
--

CREATE TABLE IF NOT EXISTS `savetable` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `Table_num` int(5) NOT NULL,
  `Reserver_Name` varchar(50) NOT NULL,
  `Email` varchar(60) NOT NULL,
  `phone_num` int(14) NOT NULL,
  `Begin_date` date NOT NULL,
  `End_date` date NOT NULL,
  `Editor_name` varchar(50) NOT NULL,
  `Edit_type` varchar(10) NOT NULL,
  `week_num` int(11) NOT NULL,
  `comments` text NOT NULL,
  `TimeStamp` timestamp NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=18 ;

--
-- Dumping data for table `savetable`
--

INSERT INTO `savetable` (`id`, `Table_num`, `Reserver_Name`, `Email`, `phone_num`, `Begin_date`, `End_date`, `Editor_name`, `Edit_type`, `week_num`, `comments`, `TimeStamp`) VALUES
(1, 58, 'dfjalkj', 'adsgfasd', 0, '2013-01-25', '2013-01-25', 'jason', 'Deletion', 0, '', '2013-01-25 14:36:40'),
(2, 33, 'ian', 'öadjföadjkd', 34543565, '2013-01-25', '2013-01-25', '4354564565', 'Deletion', 0, '', '2013-01-25 14:52:02'),
(3, 33, 'ian', 'öadjföadjkd', 34543565, '2013-01-25', '2013-01-25', '4354564565', 'Update', 0, '', '2013-01-25 16:21:21'),
(4, 33, 'ian', 'öadjföadjkd', 34543565, '2013-01-25', '2013-01-25', '4354564565', 'Update', 0, '', '2013-01-25 16:24:12'),
(5, 33, 'ian', 'öadjföadjkd', 34543565, '2013-01-25', '2013-01-31', '4354564565', 'Update', 0, '', '2013-01-25 16:25:52'),
(6, 33, 'ian', 'j@d', 200200200, '2013-01-25', '2013-01-31', '300300300', 'Update', 0, '', '2013-01-27 19:48:14'),
(7, 33, 'ian', 'j@d', 456789, '2013-01-25', '2013-01-31', '9999999', 'Deletion', 0, '', '2013-01-27 19:48:31'),
(8, 39, '39', 'jasdfkjöf', 0, '2013-01-31', '2013-02-09', '1/25/2013', 'Update', 0, '', '2013-01-28 08:59:28'),
(9, 34, 'jason', 'ajflj', 564856, '2013-02-07', '2013-02-14', 'jaond', 'Update', 0, '', '2013-01-28 09:04:13'),
(10, 33, 'wraefgds', 'sdfgsdf', 123456, '2013-01-25', '2013-01-25', 'jason', 'Deletion', 0, '', '2013-01-28 09:05:25'),
(11, 39, 'jasdfkjöf', 'fasdfasdfad', 356365, '2013-01-31', '2013-02-09', 'dasar', 'Update', 0, '', '2013-01-28 09:17:14'),
(12, 15, 'jasohn', 'fasdfas', 45635756, '2013-05-01', '2013-05-01', 'jason', 'Update', 0, '', '2013-01-28 12:02:18'),
(13, 15, 'dasar', 'fasdfas', 45635756, '2013-05-01', '2013-05-01', 'jason', 'Deletion', 0, '', '2013-01-28 12:03:46'),
(14, 34, 'jason', 'jack@joe.com', 405768767, '2013-02-07', '2013-02-14', 'jaond', 'Deletion', 0, '', '2013-01-28 12:04:03'),
(15, 28, 'dasar', 'hello', 887878, '2013-01-25', '2013-01-25', 'jason', 'Update', 0, '', '2013-02-02 10:35:47'),
(16, 28, 'dasar', 'yiouyytf', 887878, '2013-01-25', '2013-01-25', 'jason', 'Deletion', 0, '', '2013-02-02 10:35:56'),
(17, 2, 'jane', 'jane@hel', 2345563, '2013-01-25', '2013-02-14', 'dasar', 'Update', 0, '', '2013-02-04 11:54:31');

-- --------------------------------------------------------

--
-- Table structure for table `september`
--

CREATE TABLE IF NOT EXISTS `september` (
  `id` int(20) NOT NULL AUTO_INCREMENT,
  `Table_num` int(11) NOT NULL,
  `Reserver_name` varchar(50) NOT NULL,
  `Email` varchar(55) NOT NULL,
  `Phone_num` int(14) NOT NULL,
  `Begin_date` date NOT NULL,
  `End_date` date NOT NULL,
  `Editor_Name` varchar(50) NOT NULL,
  `Reserved` int(5) NOT NULL,
  `week_num` int(3) NOT NULL,
  `comments` text NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=6 ;

--
-- Dumping data for table `september`
--

INSERT INTO `september` (`id`, `Table_num`, `Reserver_name`, `Email`, `Phone_num`, `Begin_date`, `End_date`, `Editor_Name`, `Reserved`, `week_num`, `comments`) VALUES
(1, 34, 'jason', 'jack@joe.com', 405768767, '2013-02-07', '2013-02-14', 'jaond', 1, 0, ''),
(3, 39, 'jasdfkjöf', 'fasdfasdfad', 2147483647, '2013-01-31', '2013-02-09', 'dasar', 1, 0, ''),
(4, 59, 'jack', 'j@g.com', 345345456, '2013-02-06', '2013-02-13', 'jason', 1, 0, ''),
(5, 2, 'jane', 'jane@hel', 2345563, '2013-01-25', '2013-01-25', 'dasar', 1, 0, '');

-- --------------------------------------------------------

--
-- Table structure for table `viadia`
--

CREATE TABLE IF NOT EXISTS `viadia` (
  `id` int(20) NOT NULL AUTO_INCREMENT,
  `Table_num` int(11) NOT NULL,
  `Reserver_name` varchar(50) NOT NULL,
  `Email` varchar(55) NOT NULL,
  `Phone_num` int(14) NOT NULL,
  `Begin_date` date NOT NULL,
  `End_date` date NOT NULL,
  `Editor_Name` varchar(50) NOT NULL,
  `Reserved` int(5) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=12 ;

--
-- Dumping data for table `viadia`
--

INSERT INTO `viadia` (`id`, `Table_num`, `Reserver_name`, `Email`, `Phone_num`, `Begin_date`, `End_date`, `Editor_Name`, `Reserved`) VALUES
(1, 34, 'jason', 'jack@joe.com', 405768767, '2013-02-07', '2013-02-14', 'jaond', 1),
(3, 39, 'jasdfkjöf', 'fasdfasdfad', 2147483647, '2013-01-31', '2013-02-09', 'dasar', 1),
(4, 59, 'jack', 'j@g.com', 345345456, '2013-02-06', '2013-02-13', 'jason', 1),
(5, 2, 'jane', 'jane@hel', 2345563, '2013-01-25', '2013-01-25', 'dasar', 1),
(6, 11, 'in june', 'ökjakjfaö', 2147483647, '2013-06-12', '2013-06-19', 'jason', 1),
(7, 50, 'stina', 'hello', 23424354, '2013-06-13', '2013-06-20', 'jason', 1),
(8, 37, 'sadfto', 'adfa', 43543, '2013-01-25', '2013-01-25', 'jason', 1),
(9, 16, 'jaojodf', 'adfaga', 345675374, '2013-01-25', '2013-01-25', 'dasar', 1),
(11, 28, 'jason', 'khkjh', 8998998, '2013-01-25', '2013-01-25', 'jack', 1);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
