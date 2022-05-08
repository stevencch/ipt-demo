import React from 'react';
import { BrowserRouter, Route, Routes } from 'react-router-dom';
import { ProposalsList } from './features/proposals/ProposalsList';
import './App.css';

export const App: React.FC = () => {
  return (
    <BrowserRouter>
      <div className="App">
        <Routes>
          <Route path="/" element={<ProposalsList />}>
          </Route>
        </Routes>
      </div>
    </BrowserRouter>
  )
}

export default App;
