/*
 Navicat Premium Data Transfer

 Source Server         : test
 Source Server Type    : MySQL
 Source Server Version : 80021
 Source Host           : localhost:3306
 Source Schema         : bookdb

 Target Server Type    : MySQL
 Target Server Version : 80021
 File Encoding         : 65001

 Date: 04/02/2021 19:16:01
*/

SET NAMES utf8mb4;
SET FOREIGN_KEY_CHECKS = 0;

-- ----------------------------
-- Table structure for t_admin
-- ----------------------------
DROP TABLE IF EXISTS `t_admin`;
CREATE TABLE `t_admin`  (
  `id` varchar(20) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `psw` varchar(20) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  PRIMARY KEY (`id`) USING BTREE
) ENGINE = InnoDB CHARACTER SET = utf8 COLLATE = utf8_general_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of t_admin
-- ----------------------------
INSERT INTO `t_admin` VALUES ('admin', '1');

-- ----------------------------
-- Table structure for t_book
-- ----------------------------
DROP TABLE IF EXISTS `t_book`;
CREATE TABLE `t_book`  (
  `id` varchar(50) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `name` varchar(50) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  `author` varchar(20) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  `press` varchar(20) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  `number` int NULL DEFAULT NULL,
  PRIMARY KEY (`id`) USING BTREE
) ENGINE = InnoDB CHARACTER SET = utf8 COLLATE = utf8_general_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of t_book
-- ----------------------------
INSERT INTO `t_book` VALUES ('2', '网络', '固定分', '浮点', 6);
INSERT INTO `t_book` VALUES ('20190101', '计算机组成原理', '王老师', '啊啊出版社', 8);
INSERT INTO `t_book` VALUES ('20190102', '网络技术', '李老师', '不变出版署', 51);
INSERT INTO `t_book` VALUES ('6', '6', '6', '6', 6);

-- ----------------------------
-- Table structure for t_lend
-- ----------------------------
DROP TABLE IF EXISTS `t_lend`;
CREATE TABLE `t_lend`  (
  `no` int NOT NULL AUTO_INCREMENT,
  `uid` varchar(20) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  `bid` varchar(20) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  `datetime` datetime(0) NULL DEFAULT NULL,
  PRIMARY KEY (`no`) USING BTREE,
  INDEX `lend_ibfk_1`(`uid`) USING BTREE,
  INDEX `lend_ibfk_2`(`bid`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 15 CHARACTER SET = utf8 COLLATE = utf8_general_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of t_lend
-- ----------------------------
INSERT INTO `t_lend` VALUES (2, '', '20190101', '2020-12-21 09:54:45');
INSERT INTO `t_lend` VALUES (3, '', '2', '2020-12-21 09:55:30');
INSERT INTO `t_lend` VALUES (4, '', '20190102', '2020-12-21 09:55:38');
INSERT INTO `t_lend` VALUES (5, '1001', '20190102', '2020-12-21 09:58:17');
INSERT INTO `t_lend` VALUES (14, '1001', '20190102', '2020-12-21 18:10:13');

-- ----------------------------
-- Table structure for t_user
-- ----------------------------
DROP TABLE IF EXISTS `t_user`;
CREATE TABLE `t_user`  (
  `id` varchar(20) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `name` varchar(20) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  `sex` char(2) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  `psw` varchar(20) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  PRIMARY KEY (`id`) USING BTREE
) ENGINE = InnoDB CHARACTER SET = utf8 COLLATE = utf8_general_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of t_user
-- ----------------------------
INSERT INTO `t_user` VALUES ('1001', '张三', '男', '1');
INSERT INTO `t_user` VALUES ('1002', '李四', '女', '2');

SET FOREIGN_KEY_CHECKS = 1;
