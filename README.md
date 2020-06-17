# T4模板-生成NPoco实体类
从数据库生成您的“POCO”类的示例。
将NPoco框架用于ORM。

帮助资料: https://www.davidhaney.io/automatically-generate-pocos-from-db-with-t4/

## 生成文件夹
Base Folder: **Export**

Example:

- **dbo** (Default Schema)
     - User.cs (User table).
     - Role.cs (Role table).
- **Sales** (Schema for Sales)
    - Customer.cs (Customer table).
	

### 更新:

1. 更新修改支持字段注释
2. 更新支持可以为可空字段添加属性
3. 支持生成字段长度
