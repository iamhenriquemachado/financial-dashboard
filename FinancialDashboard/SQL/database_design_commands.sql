-- Table: Users
CREATE TABLE users (
	id bigint PRIMARY KEY, 
	name varchar(255), 
	email varchar(255), 
	password_hash text, 
	created_at timestamp, 
	updated_at timestamp
);

-- Table: accounts
CREATE TABLE accounts (
    account_id BIGINT PRIMARY KEY,
    user_id BIGINT,
    account_name VARCHAR(255),
    account_type VARCHAR(255),
    initial_balance NUMERIC(19,4),
    current_balance NUMERIC(19,4),
    created_at TIMESTAMP,
    updated_at TIMESTAMP,
    FOREIGN KEY (user_id) REFERENCES users(id)
);

-- TABLE: transactions
CREATE TABLE transactions (
    id BIGINT PRIMARY KEY,
    account_id BIGINT,
    category_id BIGINT,
    transaction_date DATE,
    amount NUMERIC(19,4),
    description TEXT,
    transaction_type VARCHAR(50),
    created_at TIMESTAMP,
    updated_at TIMESTAMP,
    FOREIGN KEY (account_id) REFERENCES accounts(account_id),
    FOREIGN KEY (category_id) REFERENCES categories(category_id)
);

-- Table: categories
CREATE TABLE categories (
	category_id bigint PRIMARY KEY, 
	category_name varchar(100), 
	category_type varchar(50), 
	icon varchar(255)
); 