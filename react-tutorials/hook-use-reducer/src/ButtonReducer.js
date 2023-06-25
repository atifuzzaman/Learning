var stateVariable = 0;

const ButtonReducer = (state = stateVariable,action) => {
    switch(action.type){
        case "Add":
            return state +1;
        case "Substract":
            return state -1;
        default: return state ;
    }
}

export default ButtonReducer;