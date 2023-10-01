Use TechSolutions
Create table PaymentCard(
	Id int not null Primary key,
	CardNumber int not null,
	Cvc int not null,
	CardExpiryDate varchar(5) not null,
	BillingAddress nvarchar
); 



CREATE Table Customer(
	
	CustomerId INT NOT NULL PRIMARY KEY,
	CustomerName nvarchar(100) not null,
    Email nvarchar(100) not null,
	PaymentCard int not null,
	Phone nvarchar(100) not null,
	PaymentCardId int FOREIGN KEY REFERENCES PaymentCard(Id)
	);