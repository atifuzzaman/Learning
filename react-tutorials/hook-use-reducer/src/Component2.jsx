import React, { useContext, useState } from 'react'
import { ReducerContext } from './Component';

function Component2() {
    var [confirm,sets] = useState("");
    sets("")
    var myReducer = useContext(ReducerContext);
  return (
    <div style={{backgroundColor:"black", color:"white"}}>
        <a href="#" className='btn btn-primary' onClick={(e) => {e.preventDefault();  myReducer.dispatch({type:"Add"}) }}> add </a>
        <a href="#" className='btn btn-primary' onClick={(e) => {e.preventDefault(); myReducer.dispatch({type:"Substract"}) }}> substract </a>
    </div>
 )
}

    
export default Component2