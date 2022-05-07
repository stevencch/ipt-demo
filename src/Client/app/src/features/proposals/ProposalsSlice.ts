import { createAsyncThunk,  createSlice, PayloadAction } from "@reduxjs/toolkit"
import ProposalApi from "../../api/ProposalApi";
import { RootState } from "../../app/store";
import { Proposal } from "../../types/proposals/Proposal";


export interface ProposalsState {
    proposals: Proposal[],
    status: 'idle' | 'loading' | 'succeeded' | 'failed',
    error: string | null
}

const initialState: ProposalsState = {
    proposals: [],
    status: 'idle',
    error: null
}


export const proposalSlice = createSlice({
    name: 'proposals',
    initialState,
    reducers: {
    },
    extraReducers: (builder) => {
        builder
            .addCase(fetchProposals.pending, (state) => {
                state.status = 'loading'
            })
            .addCase(fetchProposals.fulfilled, (state, action: PayloadAction<Proposal[]>) => {
                state.status = 'succeeded'
                // Add any fetched posts to the array
                state.proposals = action.payload
            })
            .addCase(fetchProposals.rejected, (state, action) => {
                state.status = 'failed'
                state.error = action.error.message ?? ''
            })
    },
})

export const fetchProposals = createAsyncThunk('proposals/fetchProposals', async () => {
    const response = await ProposalApi.getData()
    return response.data
})

export const selectAllProposals = (state: RootState): Proposal[] => state.proposals.proposals

export const selectProposalById = (state: RootState, proposalId: number) =>
    state.proposals.proposals.find(p => p.proposalId === proposalId)


export default proposalSlice.reducer

