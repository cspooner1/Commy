
import React, { Component } from 'react';
import { Route, Routes } from 'react-router-dom';
import Container from 'react-bootstrap/Container';
import Row from 'react-bootstrap/Row';
import Col from 'react-bootstrap/Col';
import axios from 'axios'

export default function Commy() {
    var response = axios.get("https://localhost:7089/categories");
    response.then(res => { console.log(res.data) });
    return (
        <>
            <h1>Commy</h1>
            <Container>
                {/*<Row>*/}
                {/*    <Col>Groceries</Col>*/}
                {/*    <Col>Clothes</Col>*/}
                {/*</Row>*/}
                {/*<Row>*/}
                {/*    <Col>Electronics</Col>*/}
                {/*    <Col>Jewelry</Col>*/}
                {/*</Row>*/}
                {/*<Row>*/}
                {/*    <Col>Home Appliancies</Col>*/}
                {/*    <Col>Instrument</Col>*/}
                {/*</Row>*/}
            </Container>
        </>
    )
}
