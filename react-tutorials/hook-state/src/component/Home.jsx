import React, { useState } from 'react'

function Home() {

    console.log("Home Component Rendered");

    const [inputText,setInputText] = useState('value');
    function setInputValueInState(e){ 
        setInputText(e.target.value);
        console.log(`Value Changed e.target.value = ${e.target.value}`);
    }

  return (
    <>
        <h1> Add the a line in the following field </h1>
        <h6> Check the console log to see when component rendered </h6>
        <input type="text" onChange={(e) => setInputValueInState(e)} value={inputText} ></input> 
        <div>
            <h4> { inputText } </h4>
        </div>
    </>
  )
}

export default Home