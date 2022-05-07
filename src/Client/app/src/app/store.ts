import { configureStore, ThunkAction, Action } from '@reduxjs/toolkit';
import proposalsReducer from '../features/proposals/ProposalsSlice'
export const store = configureStore({
  reducer: {
    proposals: proposalsReducer,
  },
});

export type AppDispatch = typeof store.dispatch;
export type RootState = ReturnType<typeof store.getState>;
export type AppThunk<ReturnType = void> = ThunkAction<
  ReturnType,
  RootState,
  unknown,
  Action<string>
>;
