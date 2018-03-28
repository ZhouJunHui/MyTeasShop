create database TeasDb on primary
(
       filename='E:\������Ŀ-��Ʒ��Ҷ\DrunkTea\Data\TeasDb.mdf',
        name='TeasDb'
)
create table Users--�û���
(
    Uid int primary key identity,
    LoginName varchar(50) not null,
    Pwd varchar(30) not null
)
create table personalInfo--������Ϣ
(
     PerId int primary key identity,
     Uid int,--�û�ID
     Uname varchar(50) not null,
     Sex varchar(2) not null default '��',
     Birthday datetime, --��������
     Phone varchar(50),--�绰����
     ImgPath varchar(255) --ͼƬ·��
)
create table Receivingaddress--�ջ���ַ
(
    RecId int primary key identity,
    Uid int,--�û�ID
    Rname varchar(30) not null,
    Phone varchar(11) not null,
    Address varchar(255) not null
)
create table Teas
(
   Tid int primary key identity,
   Tname varchar(50) not null,
   brief varchar(255) not null,--���
   price decimal(18,2) not null,
   cateId int ,--���ID
   Netcontent int not null,--������
   Place varchar(255) not null,--����
   Shelflife int not null,--������
   Purchaseqtity int,--��������
   Imagepath varchar(255)--ͼƬ·��
)

insert into Teas values('������','���д�ʦ���鰲����',195.2,1,250,'®ɽ',5,0,'~/Image/������.jpg')
insert into Teas values('������','���д�ʦ���鰲����',195.2,1,250,'®ɽ',5,0,'~/Image/������.jpg')
insert into Teas values('������','���д�ʦ���鰲����',195.2,1,250,'®ɽ',5,0,'~/Image/������.jpg')
insert into Teas values('������','���д�ʦ���鰲����',195.2,1,250,'®ɽ',5,0,'~/Image/������.jpg')
insert into Teas values('������','���д�ʦ���鰲����',195.2,1,250,'®ɽ',5,0,'~/Image/������.jpg')
insert into Teas values('������','���д�ʦ���鰲����',195.2,1,250,'®ɽ',5,0,'~/Image/������.jpg')
insert into Teas values('������','���д�ʦ���鰲����',195.2,1,250,'®ɽ',5,0,'~/Image/������.jpg')
insert into Teas values('������','���д�ʦ���鰲����',195.2,1,250,'®ɽ',5,0,'~/Image/������.jpg')
insert into Teas values('������','���д�ʦ���鰲����',195.2,1,250,'®ɽ',5,0,'~/Image/������.jpg')


create table Cates--����
(
    cateId int primary key identity,
    cateName varchar(50) not null
)
create table orders
(
    OrId int primary key identity,
    Uid int,--�û�Id
    Ordernumber varchar(50) not null,--������
    Ordertime datetime not null,--�µ�ʱ��
    Total decimal(18,2) not null,--�ܼ�
    RecId int--�ջ���ַID
)
create table OrderDetailed --������ϸ
(
     OrDetaId int primary key identity,
     OrId int ,--����ID
     Tid int,--��ҶID
     Number int not null,--����
     Price decimal(18,2)--����
)
create table Cart--���ﳵ
(
     CarId int primary key identity,
     Uid int,--�û�ID
     Tid int,--��ҶID
     Number int not null,--����
)