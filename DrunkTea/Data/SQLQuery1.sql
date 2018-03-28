create database TeasDb on primary
(
       filename='E:\个人项目-醉品茶叶\DrunkTea\Data\TeasDb.mdf',
        name='TeasDb'
)
create table Users--用户表
(
    Uid int primary key identity,
    LoginName varchar(50) not null,
    Pwd varchar(30) not null
)
create table personalInfo--个人信息
(
     PerId int primary key identity,
     Uid int,--用户ID
     Uname varchar(50) not null,
     Sex varchar(2) not null default '男',
     Birthday datetime, --出生日期
     Phone varchar(50),--电话号码
     ImgPath varchar(255) --图片路径
)
create table Receivingaddress--收货地址
(
    RecId int primary key identity,
    Uid int,--用户ID
    Rname varchar(30) not null,
    Phone varchar(11) not null,
    Address varchar(255) not null
)
create table Teas
(
   Tid int primary key identity,
   Tname varchar(50) not null,
   brief varchar(255) not null,--简介
   price decimal(18,2) not null,
   cateId int ,--类别ID
   Netcontent int not null,--净含量
   Place varchar(255) not null,--产地
   Shelflife int not null,--保质期
   Purchaseqtity int,--购买数量
   Imagepath varchar(255)--图片路径
)

insert into Teas values('铁观音','传承大师刘洪安制作',195.2,1,250,'庐山',5,0,'~/Image/铁观音.jpg')
insert into Teas values('铁观音','传承大师刘洪安制作',195.2,1,250,'庐山',5,0,'~/Image/铁观音.jpg')
insert into Teas values('铁观音','传承大师刘洪安制作',195.2,1,250,'庐山',5,0,'~/Image/铁观音.jpg')
insert into Teas values('铁观音','传承大师刘洪安制作',195.2,1,250,'庐山',5,0,'~/Image/铁观音.jpg')
insert into Teas values('铁观音','传承大师刘洪安制作',195.2,1,250,'庐山',5,0,'~/Image/铁观音.jpg')
insert into Teas values('铁观音','传承大师刘洪安制作',195.2,1,250,'庐山',5,0,'~/Image/铁观音.jpg')
insert into Teas values('铁观音','传承大师刘洪安制作',195.2,1,250,'庐山',5,0,'~/Image/铁观音.jpg')
insert into Teas values('铁观音','传承大师刘洪安制作',195.2,1,250,'庐山',5,0,'~/Image/铁观音.jpg')
insert into Teas values('铁观音','传承大师刘洪安制作',195.2,1,250,'庐山',5,0,'~/Image/铁观音.jpg')


create table Cates--类别表
(
    cateId int primary key identity,
    cateName varchar(50) not null
)
create table orders
(
    OrId int primary key identity,
    Uid int,--用户Id
    Ordernumber varchar(50) not null,--订单号
    Ordertime datetime not null,--下单时间
    Total decimal(18,2) not null,--总价
    RecId int--收货地址ID
)
create table OrderDetailed --订单明细
(
     OrDetaId int primary key identity,
     OrId int ,--订单ID
     Tid int,--茶叶ID
     Number int not null,--数量
     Price decimal(18,2)--单价
)
create table Cart--购物车
(
     CarId int primary key identity,
     Uid int,--用户ID
     Tid int,--茶叶ID
     Number int not null,--数量
)