use EstrelaDaMorte;

create table Planetas(
	IdPlaneta int primary key identity(1,1),
	Nome varchar(50) not null,
	Rotacao float not null,
	Orbita float not null,
	Diametro float not null,
	Clima varchar(50),
	Populacao int not null
);

select * from Planetas;

create table Naves(
	IdNave int primary key identity(1,1),
	Nome varchar(100) not null,
	Modelo varchar(150) not null,
	Passageiros int not null,
	Carga float not null,
	Classe varchar(100) not null
);

create table Pilotos(
	IdPiloto int primary key identity(1,1),
	Nome varchar(200) not null,
	AnoNascimento varchar(10) not null,
	IdPlaneta int not null,
	constraint fk_pilotos_planetas foreign key (IdPlaneta) references Planetas (IdPlaneta)
);

create table PilotosNaves(
	IdPiloto int not null,
	IdNave int not null,
	FlagAutorizado bit not null,
	constraint pk_pilotosNaves primary key (IdPiloto, IdNave),
	constraint fk_pilotosNaves_Piloto foreign key (IdPiloto) references Pilotos(IdPiloto),
	constraint fk_pilotosNaves_Nave foreign key (IdNave) references Naves(IdNave)
);
/* Não consegui adicionar essa constraint no escopo do comando create table, pesquisar depois o pq */
alter table PilotosNaves add constraint df_PilotosNaves_FlagAutorizado default 1 FOR FlagAutorizado;

create table HistoricoViagens(
	IdPiloto int not null,
	IdNave int not null,
	DtSaida datetime not null,
	DtChegada datetime not null,
	constraint fk_HistoricoViagens_PilotosNaves foreign key (IdPiloto, IdNave) references PilotosNaves(IdPiloto, IdNave)
);
