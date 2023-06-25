
var initialState = 10;
console.log("button reducers renders");
function buttonReducers(state= initialState, action) {
    switch(action.type){
        case 'Increment':
            return state+action.payload;
        case 'Decrement':
            return state-action.payload;
        default:
            return state;
    }
}

export default buttonReducers