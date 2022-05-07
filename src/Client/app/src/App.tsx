import React from 'react';
import logo from './logo.svg';
import './App.css';
import { BrowserRouter, Route, Routes } from 'react-router-dom';
import { ProposalsList } from './features/proposals/ProposalsList';

function App() {
  return (
    <BrowserRouter>
      <div className="App">
        <Routes>
          <Route path="/" element={<ProposalsList />}>
          </Route>
        </Routes>
      </div>
    </BrowserRouter>
  );
}

export default App;
