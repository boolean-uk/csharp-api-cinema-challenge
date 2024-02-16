
CREATE TABLE Customers
(
  id         SERIAL       NULL    ,
  name       VARCHAR(255) NOT NULL,
  email      VARCHAR(255) NOT NULL,
  phone      VARCHAR(50)  NOT NULL,
  created_at TIME         NULL     DEFAULT CURRENT_TIMESTAMP,
  updated_at TIME         NULL     DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (id)
);

ALTER TABLE Customers
  ADD CONSTRAINT UQ_email UNIQUE (email);

CREATE TABLE Movies
(
  id           SERIAL       NULL    ,
  title        VARCHAR(255) NOT NULL,
  rating       VARCHAR(50)  NULL    ,
  description  TEXT         NULL    ,
  runtime_mins INTEGER      NOT NULL,
  created_at   TIME         NULL     DEFAULT CURRENT_TIMESTAMP,
  updated_at   TIME         NULL     DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (id)
);

CREATE TABLE Screenings
(
  id            SERIAL  NULL    ,
  movie_id      INTEGER NOT NULL,
  screen_number INTEGER NOT NULL,
  capacity      INTEGER NOT NULL,
  starts_at     TIME    NOT NULL,
  created_at    TIME    NULL     DEFAULT CURRENT_TIMESTAMP,
  updated_at    TIME    NULL     DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (id)
);

CREATE TABLE Tickets
(
  fk_customer_id  INTEGER NOT NULL,
  fk_screening_id INTEGER NOT NULL,
  num_seats       INTEGER NOT NULL,
  created_at      TIME    NULL     DEFAULT CURRENT_TIMESTAMP,
  updated_at      TIME    NULL     DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (fk_customer_id, fk_screening_id)
);

ALTER TABLE Screenings
  ADD CONSTRAINT FK_Movies_TO_Screenings
    FOREIGN KEY (movie_id)
    REFERENCES Movies (id);

ALTER TABLE Tickets
  ADD CONSTRAINT FK_Customers_TO_Tickets
    FOREIGN KEY (fk_customer_id)
    REFERENCES Customers (id);

ALTER TABLE Tickets
  ADD CONSTRAINT FK_Screenings_TO_Tickets
    FOREIGN KEY (fk_screening_id)
    REFERENCES Screenings (id);
