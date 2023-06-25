import buttonReducers from "./reducers";
import { configureStore } from "@reduxjs/toolkit";

console.log("store renders");

export const store = configureStore({reducer:{button:buttonReducers}});



// import React from 'react'
// import { connect } from 'react-redux'

// export const store = (props) => {
//   return (
//     <div>store</div>
//   )
// }

// const mapStateToProps = (state) => ({})

// const mapDispatchToProps = {}

// export default connect(mapStateToProps, mapDispatchToProps)(store)