import React, { useContext } from 'react'
import { StateContext } from './App';
import {MyContext} from './index'


function CustomCompoenent() {
  var myContext = useContext(MyContext);
  var stateContext = useContext(StateContext);
    //stateContext.setVariable('my data');
  return (
    <>
        <h1> {myContext} </h1>
        <h2> {stateContext.variable} </h2>
    </>
  )
}

export default CustomCompoenent