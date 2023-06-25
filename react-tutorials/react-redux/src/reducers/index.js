import { combineReducers } from "redux";
import buttonReducers from './buttonReducers'

const rootReducers = combineReducers(
    {
        buttonReducers
    }
)

export default rootReducers;
