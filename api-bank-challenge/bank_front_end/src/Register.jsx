import React, { useState } from "react";
import axios from "axios";

export const Register = (props) => {
    const [email, setEmail] = useState('');
    const [pass, setPass] = useState('');
    const [name, setName] = useState('');
    const [phone, setPhone] = useState('');

    const handleSubmit = (e) => {
        e.preventDefault();
        console.log(email);
    }
    const handleRegister = () => {
        const data = {
            name: name,
            Email: email,
            Password: pass,
            Phone: phone
        };
        console.log(name);
        console.log(email);
        console.log(pass);
        console.log(phone);
        // When the user hit register button, I Get all the info and i add the user to db
        // Then i get the user id and i create an account for him with 0 balance and his id as user id
        // 2 posts: One for user, one for account
        const url = 'https://localhost:7195/users';
        const url_acc = 'https://localhost:7195/account';

        axios.post(url, data).then(res => {
            console.log(res.data);
            const account_data = {
                balance: 0,
                UserId: res.data.id
            }
            axios.post(url_acc, account_data).then(res_acc => {
                console.log(res_acc);
            }) 
        })
        /*
        const url = 'https://localhost:7195/users';
        fetch(url, {  // Enter your IP address here

            method: 'POST',
            cors: 
            headers: {'Content-type':'application/json'},
            body: JSON.stringify(data) // body data type must match "Content-Type" header
        }).then(r => r.json()).then(res => {
            if (res) {
                this.setState({ message: "Created" });
            }
        })*/
    }
    

    return (
        <div className="auth-form-container">
            <h2>Register</h2>
            <form className="register-form" onSubmit={handleSubmit}>
                <label htmlFor="name">Full name</label>
                <input value={name} name="name" onChange={(e) => setName(e.target.value)} id="name" placeholder="full Name" />
                <label htmlFor="email">email</label>
                <input value={email} onChange={(e) => setEmail(e.target.value)} type="email" placeholder="youremail@gmail.com" id="email" name="email" />
                <label htmlFor="password">password</label>
                <input value={pass} onChange={(e) => setPass(e.target.value)} type="password" placeholder="********" id="password" name="password" />
                <label htmlFor="phone">phone</label>
                <input value={phone} onChange={(e) => setPhone(e.target.value)} type="phone" placeholder="+30 " id="phone" name="phone" />
                <button type="submit" onClick={()=> handleRegister()}>Register</button>
            </form>
            <button className="link-btn" onClick={() => props.onFormSwitch('login')}>Already have an account? Login here.</button>
        </div>
    )
}