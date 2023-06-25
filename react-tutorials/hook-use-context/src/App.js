import logo from './logo.svg';
import './App.css';
import React,{ useState } from 'react';
import CustomCompoenent from './CustomCompoenent';

var StateContext = React.createContext({});

function App() {
  const [variable,setVariable] = useState('This is state Text');
  return (
    <StateContext.Provider value={{variable,setVariable}}>
      <div className="App">
        <CustomCompoenent></CustomCompoenent>
        <header className="App-header">
          <img src={logo} className="App-logo" alt="logo" />
          <p>
            Edit <code>src/App.js</code> and save to reload.
          </p>
          <a
            className="App-link"
            href="https://reactjs.org"
            target="_blank"
            rel="noopener noreferrer"
          >
            Learn React
          </a>
        </header>
      </div>
    </StateContext.Provider>    
  );
}

export default App;
export {StateContext}