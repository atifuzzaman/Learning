import React, { useReducer } from 'react'
import ButtonReducer from './ButtonReducer'
import Component2 from './Component2';


const ReducerContext = React.createContext({});

function Component() {

    const [state,dispatch] = useReducer(ButtonReducer,0);
    
    return (
    <>
    
        <div style={{ backgroundColor:"#ccc" }}>
            <h1> {state} </h1>
            <button onClick={() => dispatch({type:"Add"})}> Add </button>
            <button onClick={() => dispatch({type:"Substract"})}> Substract </button>
        </div>
        <ReducerContext.Provider value={{state,dispatch}}>
            <Component2></Component2>
        </ReducerContext.Provider>
    </>
  )
}

export default Component
export {ReducerContext}