import React, { Component } from 'react';
import { Route, Routes } from 'react-router-dom';
import AppRoutes from './AppRoutes';
import { Layout } from './components/Layout';
import './custom.css';
import Commy from './components/Commy';

export default class App extends Component {
    static displayName = App.name;

    render() {
        return (
            <>
                <Layout>

                </Layout>
                <Commy />
            </>

        );
    }
}
