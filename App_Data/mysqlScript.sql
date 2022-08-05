-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

-- -----------------------------------------------------
-- Schema mydb
-- -----------------------------------------------------
-- -----------------------------------------------------
-- Schema litrevresourcedb
-- -----------------------------------------------------
DROP SCHEMA IF EXISTS `litrevresourcedb` ;

-- -----------------------------------------------------
-- Schema litrevresourcedb
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `litrevresourcedb` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci ;
USE `litrevresourcedb` ;

-- -----------------------------------------------------
-- Table `litrevresourcedb`.`module_table`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `litrevresourcedb`.`module_table` (
  `Assign_IdNum` INT NOT NULL,
  `Assign_Name` VARCHAR(100) NOT NULL,
  `Assign_DueDate` DATE NULL DEFAULT NULL,
  `Assign_Trimester` INT NULL DEFAULT NULL,
  `Mod_IdNum` INT NULL DEFAULT NULL,
  PRIMARY KEY (`Assign_IdNum`),
  INDEX `Mod_IdNum_idx` (`Mod_IdNum` ASC) VISIBLE)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `litrevresourcedb`.`assignment_table`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `litrevresourcedb`.`assignment_table` (
  `Assign_IdNum` INT NOT NULL,
  `Assign_Name` VARCHAR(100) NOT NULL,
  `Assign_DueDate` DATE NULL DEFAULT NULL,
  `Assign_Trimester` INT NULL DEFAULT NULL,
  `Mod_IdNum` INT NULL DEFAULT NULL,
  PRIMARY KEY (`Assign_IdNum`),
  INDEX `Mod_IdNum_idx` (`Mod_IdNum` ASC) VISIBLE,
  CONSTRAINT `Mod_IdNum`
    FOREIGN KEY (`Mod_IdNum`)
    REFERENCES `litrevresourcedb`.`module_table` (`Mod_IdNum`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `litrevresourcedb`.`resource_table`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `litrevresourcedb`.`resource_table` (
  `Res_IdNum` INT NOT NULL,
  `Res_Weblink` VARCHAR(100) NULL DEFAULT NULL,
  `Res_Type` VARCHAR(20) NULL DEFAULT NULL,
  `Res_DoiNum` VARCHAR(30) NULL DEFAULT NULL,
  `Res_DateAccessed` DATE NULL DEFAULT NULL,
  `Res_Category` VARCHAR(20) NULL DEFAULT NULL,
  `Res_Reference` VARCHAR(100) NULL DEFAULT NULL,
  `Res_MainPoint` VARCHAR(2000) NULL DEFAULT NULL,
  `Res_Notes` VARCHAR(4000) NULL DEFAULT NULL,
  `Assign_IdNum` INT NULL DEFAULT NULL,
  PRIMARY KEY (`Res_IdNum`),
  INDEX `Assign_IdNum_idx` (`Assign_IdNum` ASC) VISIBLE,
  CONSTRAINT `Assign_IdNum`
    FOREIGN KEY (`Assign_IdNum`)
    REFERENCES `litrevresourcedb`.`assignment_table` (`Assign_IdNum`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
