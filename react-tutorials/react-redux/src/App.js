import logo from './logo.svg';
import './App.css';
import { useDispatch, useSelector } from 'react-redux';
import { IncrementNumber, DecrementNumber } from './actions';


console.log("app.js renders");
function App() {
  var dispatch = useDispatch();
  var state = useSelector((state) =>  state.button.buttonReducers);
  var data = 'This is my data ';
  return (
    <div className="App">
      <button onClick={() => dispatch(IncrementNumber()) }>+</button>
      <button onClick={() => dispatch(DecrementNumber()) }>-</button>
      <h1> {data} {state}  </h1>
    </div>
  );
}

export default App;
