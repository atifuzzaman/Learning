import React, { useEffect, useState } from 'react'

function Home() {

    console.log("Home Component Rendered");

    const [inputText,setInputText] = useState('value');
    const [fixedText,setFixedText] = useState('');

    useEffect(
        () => {
            console.log('Use Effect is rendered ');
            setFixedText('This text is fixed in state and wont change even if component is rendered');
            return () => { console.log('use effect is removed from page'); }
        }
        , 
        // this empty array show there is no dependancy 
        // if there is any variable or property of element then it will run again when that property or ariable changes  
        [] 

        )

    function setInputValueInState(e){ 
        setInputText(e.target.value);
        console.log(`Value Changed e.target.value = ${e.target.value}`);
    }

  return (
    <>
        <h6>{fixedText}</h6>
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