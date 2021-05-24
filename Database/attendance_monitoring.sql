-- phpMyAdmin SQL Dump
-- version 5.0.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Apr 02, 2021 at 06:21 PM
-- Server version: 10.4.11-MariaDB
-- PHP Version: 7.4.2

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `attendance_monitoring`
--

-- --------------------------------------------------------

--
-- Table structure for table `attendance`
--

CREATE TABLE `attendance` (
  `attendance_id` varchar(20) NOT NULL,
  `user_id` varchar(50) DEFAULT NULL,
  `time` varchar(20) DEFAULT NULL,
  `status` varchar(10) DEFAULT NULL,
  `date` varchar(10) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `attendance`
--

INSERT INTO `attendance` (`attendance_id`, `user_id`, `time`, `status`, `date`) VALUES
('attendance-00120', 'Emp-00256', '12:14:39 AM', 'Time-in', '2021/04/03'),
('attendance-00394', 'Emp-00256', '6:38:15 PM', 'Time-in', '2021/04/02'),
('attendance-00698', 'Emp-00256', '10:44:39 AM', 'Time-out', '2021/04/01'),
('attendance-00721', 'Emp-00256', '9:06:55 PM', 'Time-in', '2021/04/01'),
('attendance-00741', 'Emp-00256', '6:38:17 PM', 'Time-out', '2021/04/02'),
('attendance-00780', 'Emp-00396', '9:15:41 PM', 'Time-in', '2021/04/01'),
('attendance-00899', 'Emp-00256', '12:14:42 AM', 'Time-out', '2021/04/03'),
('attendance-00946', 'Emp-00396', '9:15:43 PM', 'Time-out', '2021/04/01');

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE `users` (
  `user_id` varchar(50) NOT NULL,
  `username` varchar(50) NOT NULL,
  `password` varchar(50) NOT NULL,
  `firstname` varchar(50) NOT NULL,
  `middlename` varchar(50) NOT NULL,
  `lastname` varchar(50) NOT NULL,
  `address` varchar(50) NOT NULL,
  `age` int(3) NOT NULL,
  `gender` varchar(7) NOT NULL,
  `usertype` varchar(20) NOT NULL,
  `date_created` varchar(50) DEFAULT NULL,
  `date_updated` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`user_id`, `username`, `password`, `firstname`, `middlename`, `lastname`, `address`, `age`, `gender`, `usertype`, `date_created`, `date_updated`) VALUES
('Emp-00256', 'employee', 'employee', 'Anicka', 'Adorable', 'Drilon', 'Bolong Este', 21, 'Female', 'employee', NULL, '2021-03-31 00:37:37.749982'),
('Emp-00396', 'ian', 'ian', 'daw', 'dwa', 'dwa', 'daw', 12, 'Female', 'employee', '2021-04-01 15:25:52.281699', '2021-04-01 21:12:31.240685'),
('Emp-259', 'admin', 'admin', 'Ian', 'Adorable', 'Drilon', 'Brgy. Bolong Este Santa Barbara', 21, 'Male', 'admin', NULL, '2021-03-31 10:53:42.785319');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `attendance`
--
ALTER TABLE `attendance`
  ADD PRIMARY KEY (`attendance_id`),
  ADD KEY `user_id` (`user_id`);

--
-- Indexes for table `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`user_id`);

--
-- Constraints for dumped tables
--

--
-- Constraints for table `attendance`
--
ALTER TABLE `attendance`
  ADD CONSTRAINT `attendance_ibfk_1` FOREIGN KEY (`user_id`) REFERENCES `users` (`user_id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
