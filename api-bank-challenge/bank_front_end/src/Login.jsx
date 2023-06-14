import React, { useState, useEffect } from "react";
import { useNavigate } from 'react-router-dom';
import axios from "axios";

export const Login = (props) => {
    const [email, setEmail] = useState('');
    const [pass, setPass] = useState('');
    const [users, setUsers] = useState([]);

    //Get All the users into an array
    useEffect(() => {
        fetch('https://localhost:7195/users')
            .then((res) => res.json())
            .then((data) => {
                console.log(data);
                setUsers(data);
            })
            .catch((err) => {
                console.log(err.message);
            });
    }, []);

    const handleSubmit = (e) => {
        e.preventDefault();
    }

    const navigate = useNavigate();
    const url = 'https://localhost:7195/users';

    const handleLogin = () => {
        console.log(email);
        console.log(pass);
        console.log(users[4]);
        users.map(user => {
            if (user.email === email && user.password === pass) {
                navigate("/Menu");
            }
        })
        
    }

    return (
        <div className="auth-form-container">
            <h2>Login</h2>
            <form className="login-form" onSubmit={handleSubmit}>
                <label htmlFor="email">email</label>
                <input value={email} onChange={(e) => setEmail(e.target.value)} type="email" placeholder="youremail@gmail.com" id="email" name="email" />
                <label htmlFor="password">password</label>
                <input value={pass} onChange={(e) => setPass(e.target.value)} type="password" placeholder="********" id="password" name="password" />
                <button type="submit" onClick={() => handleLogin()}>Log In</button>
            </form>
            <button className="link-btn" onClick={() => props.onFormSwitch('register')}>Don't have an account? Register here.</button>
        </div>
    )
}