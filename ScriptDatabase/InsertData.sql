USE project_klbf
GO

insert into Language(Name, Code) values ('INDONESIA', 'ID'), ('ENGLISH', 'EN');

insert into Number(Number) values (1);

insert into Currency(Name, Code) values ('INDONESIA (IDR)', 'IDR'), ('UNITED STATES DOLLAR (USD)', 'USD');

insert into UOM(Name, Code) values ('Hours', 'hr'),('Minutes', 'mn'),('Seconds','sc'),('Liters','l'),('Mililiters','ml'),('Kilograms','kg'),('Grams','g');

insert into Customer(Name, Address, LogoURL) values ('Tono','Pamulang - Banten','https://miro.medium.com/max/1100/0*MSmp3gLEbtHbMloT.png'), ('John Doe','Cikarang - Jawa Barat','https://upload.wikimedia.org/wikipedia/commons/thumb/6/67/Kalbe_Farma.svg/1200px-Kalbe_Farma.svg.png');

insert into Purchase(PrchNo, Amount, PIC) values ('FL-001','10000','Amir'), ('FL-002','12000','Faizal');

