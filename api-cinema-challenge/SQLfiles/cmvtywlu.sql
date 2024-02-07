-- This script only contains the table creation statements and does not fully represent the table in the database. It's still missing: indices, triggers. Do not use it as a backup.

-- Table Definition
CREATE TABLE "public"."customer" (
    "id" int4 NOT NULL,
    "name" text NOT NULL,
    "email" text NOT NULL,
    "phone" text NOT NULL,
    "created_at" timestamptz NOT NULL,
    "updated_at" timestamptz NOT NULL,
    PRIMARY KEY ("id")
);

-- This script only contains the table creation statements and does not fully represent the table in the database. It's still missing: indices, triggers. Do not use it as a backup.

-- Table Definition
CREATE TABLE "public"."movie" (
    "id" int4 NOT NULL,
    "title" text NOT NULL,
    "rating" text NOT NULL,
    "description" text NOT NULL,
    "runtime_mins" int4 NOT NULL,
    "created_at" timestamptz NOT NULL,
    "updated_at" timestamptz NOT NULL,
    PRIMARY KEY ("id")
);

-- This script only contains the table creation statements and does not fully represent the table in the database. It's still missing: indices, triggers. Do not use it as a backup.

-- Table Definition
CREATE TABLE "public"."screening" (
    "id" int4 NOT NULL,
    "screen_number" int4 NOT NULL,
    "capacity" int4 NOT NULL,
    "starts_at" timestamptz NOT NULL,
    "movie_id" int4 NOT NULL,
    "CustomerId" int4,
    CONSTRAINT "FK_screening_customer_CustomerId" FOREIGN KEY ("CustomerId") REFERENCES "public"."customer"("id"),
    CONSTRAINT "FK_screening_movie_movie_id" FOREIGN KEY ("movie_id") REFERENCES "public"."movie"("id") ON DELETE CASCADE,
    PRIMARY KEY ("id")
);

-- This script only contains the table creation statements and does not fully represent the table in the database. It's still missing: indices, triggers. Do not use it as a backup.

-- Table Definition
CREATE TABLE "public"."ticket" (
    "id" int4 NOT NULL,
    "num_seats" int4 NOT NULL,
    "created_at" timestamptz NOT NULL,
    "updated_at" timestamptz NOT NULL,
    "customer_id" int4 NOT NULL,
    "screening_id" int4 NOT NULL,
    CONSTRAINT "FK_ticket_customer_customer_id" FOREIGN KEY ("customer_id") REFERENCES "public"."customer"("id") ON DELETE CASCADE,
    PRIMARY KEY ("id")
);

INSERT INTO "public"."customer" ("id", "name", "email", "phone", "created_at", "updated_at") VALUES
(1, 'Henrik Rosenkilde', 'john@example.com', '1234567890', '2024-02-06 09:54:49.699763+00', '2024-02-06 09:54:49.699763+00');
INSERT INTO "public"."customer" ("id", "name", "email", "phone", "created_at", "updated_at") VALUES
(2, 'Anette Mari Rosenkilde', 'john@example.com', '1234567890', '2024-02-06 09:54:49.699763+00', '2024-02-06 09:54:49.699763+00');


INSERT INTO "public"."movie" ("id", "title", "rating", "description", "runtime_mins", "created_at", "updated_at") VALUES
(1, 'The Matrix', 'R', 'A computer hacker learns about the true nature of reality and his role in the war against its controllers.', 136, '2024-02-06 09:54:49.699775+00', '2024-02-06 09:54:49.699775+00');
INSERT INTO "public"."movie" ("id", "title", "rating", "description", "runtime_mins", "created_at", "updated_at") VALUES
(2, 'The Hobbit', 'PG-13', 'A reluctant hobbit, Bilbo Baggins, sets out to the Lonely Mountain with a spirited group of dwarves to reclaim their mountain home, and the gold within it, from the dragon Smaug.', 169, '2024-02-06 09:54:49.699775+00', '2024-02-06 09:54:49.699775+00');


INSERT INTO "public"."screening" ("id", "screen_number", "capacity", "starts_at", "movie_id", "CustomerId") VALUES
(1, 5, 40, '2024-02-06 09:54:49.699776+00', 1, NULL);


INSERT INTO "public"."ticket" ("id", "num_seats", "created_at", "updated_at", "customer_id", "screening_id") VALUES
(1, 2, '-infinity', '-infinity', 1, 1);
INSERT INTO "public"."ticket" ("id", "num_seats", "created_at", "updated_at", "customer_id", "screening_id") VALUES
(2, 3, '-infinity', '-infinity', 2, 1);

