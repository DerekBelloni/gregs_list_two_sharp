CREATE TABLE IF NOT EXISTS accounts(
  id VARCHAR(255) NOT NULL primary key COMMENT 'primary key',
  createdAt DATETIME DEFAULT CURRENT_TIMESTAMP COMMENT 'Time Created',
  updatedAt DATETIME DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP COMMENT 'Last Update',
  name varchar(255) COMMENT 'User Name',
  email varchar(255) COMMENT 'User Email',
  picture varchar(255) COMMENT 'User Picture'
) default charset utf8 COMMENT '';
CREATE TABLE IF NOT EXISTS cars(
  id INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
  create_time DATETIME DEFAULT CURRENT_TIMESTAMP COMMENT 'Create Time',
  update_time DATETIME DEFAULT CURRENT_TIMESTAMP COMMENT 'Update Time',
  make TEXT NOT NULL COMMENT 'Vehicle Make',
  model TEXT NOT NULL COMMENT 'Vehicle Model',
  year INT NOT NULL,
  color TEXT NOT NULL COMMENT 'Vehicle Color'
) default charset utf8 COMMENT '';