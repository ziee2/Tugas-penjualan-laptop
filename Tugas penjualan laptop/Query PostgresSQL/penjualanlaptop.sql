CREATE TABLE laptop(
	IDLaptop serial not null,
	nama_laptop varchar(128) not null,
	harga_laptop integer not null,
	stok integer not null,
	constraint laptop_pk primary key (IDLaptop)
);
drop table transaksi

CREATE TABLE transaksi(
	IDTransaksi serial not null,
	NamaPembeli varchar(100),
	tanggal_transaksi TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
	constraint Transaksi_pk primary key (IDTransaksi)
	
);
drop table detail_transaksi

CREATE TABLE detail_transaksi(
	IDdetail_transaksi serial not null,
	id_transaksi int not null,
	id_laptop int not null,
	jumlah int not null,
	constraint id_detail_transaksi_pk primary key (IDdetail_transaksi),
	constraint transaksi_pk foreign key (id_transaksi) references transaksi(IDTransaksi),
	constraint laptop_pk foreign key (id_laptop) references laptop(IDLaptop)
);

select * from laptop
select * from transaksi
select * from detail_transaksi

drop function insert_laptop
-- insert function laptop
create or replace function insert_laptop(_nama_laptop varchar(128), _harga_laptop integer, _stok integer)
returns int AS 
$$
begin
	insert into laptop(nama_laptop, harga_laptop, stok)
	values(_nama_laptop, _harga_laptop, _stok);
	if found then --inserted successfully 
		return 1;
	else 
		return 0; -- insert fail
	end if;
end
$$
language plpgsql

drop function insert_transaksi
-- insert transaksi
create or replace function insert_transaksi(_NamaPembeli varchar(100))
returns int AS 
$$
begin
	insert into transaksi(NamaPembeli)
	values(_NamaPembeli);
	if found then --inserted successfully 
		return 1;
	else 
		return 0; -- insert fail
	end if;
end
$$
language plpgsql

drop function insert_detail
-- insert detail
create or replace function insert_detail(_id_transaksi int,_id_laptop int, _jumlah int)
returns int AS 
$$
begin
	insert into detail_transaksi(id_transaksi, id_laptop, jumlah)
	values(_id_transaksi, _id_laptop, _jumlah);
	if found then --inserted successfully 
		return 1;
	else 
		return 0; -- insert fail
	end if;
end
$$
language plpgsql

-- test fuction insert laptop
select * from insert_laptop('Asu',11000000, 2)

-- test insert transaksi
select * from insert_transaksi('ziee')

-- test insert detail

select * from insert_detail(3, 7, 1)

-- update function laptop
create or replace function Update_laptop(_IDLaptop int, _nama_laptop varchar(128), _harga_laptop int, _stok int)
returns int as 
$$
begin 
	update laptop
	set
		nama_laptop = _nama_laptop,
		harga_laptop = _harga_laptop,
		stok = _stok
	where IDLaptop = _IDLaptop;
	if found then --updated successfully
		return 1;
	else		  --updated fail
		return 0;
	end if;
end
$$
language plpgsql




-- test update
select * from Update_laptop(1,'Asus Nitro',15000000, 2)

-- select fuction
create or replace function Select_laptop()
returns table
(
	ID_Laptop int,
	Nama varchar(128),
	Harga int,
	Stokk int
) as
$$
begin
	return query
	select IDLaptop, nama_laptop, harga_laptop, stok from laptop order by IDLaptop;
end
$$
language plpgsql

drop function Select_detail
-- select detail

create or replace function Select_detail()
returns table
(
	ID_detail_transaksi int,
	idtransaksi int,
	idlaptop int,
	jumlah_dibeli int
) as
$$
begin
	return query
	select IDdetail_transaksi, id_transaksi, id_laptop, jumlah from detail_transaksi order by IDdetail_transaksi;
end
$$
language plpgsql
drop function Select_transaksi
-- select transaksi

create or replace function Select_transaksi()
returns table
(
	ID_Transaksi int,
	Nama_Pembeli varchar(100),
	tanggal timestamp without time zone
) as
$$
begin
	return query
	select IDTransaksi, NamaPembeli, tanggal_transaksi from transaksi order by IDTransaksi;
end
$$
language plpgsql

-- test select function

select * from Select_laptop();
-- test select transaksi
select * from Select_transaksi();

-- delete funtion laptop
create or replace function Delete_laptop(_IDLaptop int)
returns int as
$$
begin
	delete from laptop
	where IDLaptop = _IDLaptop;
	if found then -- deleted successfully
		return 1;
	else
		return 0;
	end if;
end
$$
language plpgsql

-- delete transaksi
create or replace function Delete_transaksi(_IDTransaksi int)
returns int as
$$
begin
	delete from transaksi
	where IDTransaksi = _IDTransaksi;
	if found then -- deleted successfully
		return 1;
	else
		return 0;
	end if;
end
$$
language plpgsql

--test delete 
select * from Select_laptop()

select * from Delete_laptop(1)

-- Ubah tipe data kolom ID jika diperlukan
-- Jika ID belum ada, tambahkan kolom baru
ALTER TABLE FansBase ALTER COLUMN IDFans TYPE int;

-- Setel kolom ID sebagai AUTO_INCREMENT
ALTER TABLE FansBase ALTER COLUMN IDFans SET NOT NULL;




UPDATE laptop SET stok = stok - (SELECT stok_dibeli FROM detail_transaksi WHERE id_laptop = laptop.IDLaptop ) 
WHERE IDLaptop IN (SELECT id_laptop FROM detail_transaksi)

alter sequence detail_transaksi_id_detail_transaksi_seq restart increment by 1