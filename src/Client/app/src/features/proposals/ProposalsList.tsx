import React, { useEffect } from 'react'
import { useAppSelector, useAppDispatch } from '../../app/hooks';
import { MemoizedProposalDataGrid } from '../../components/proposals/ProposalDataGrid';
import { Spinner } from '../../components/Spinner';
import { fetchProposals, selectAllProposals } from './ProposalsSlice';

export const ProposalsList: React.FC = () => {
    const dispatch = useAppDispatch()
    const proposals = useAppSelector(selectAllProposals);
    const proposalStatus = useAppSelector(state => state.proposals.status)
    const error = useAppSelector(state => state.proposals.error)

    useEffect(() => {
        if (proposalStatus === 'idle') {
            dispatch(fetchProposals())
        }
    }, [proposalStatus,dispatch])

    let content

    if (proposalStatus === 'loading') {
        content = <Spinner text="Loading..."  />
    } else if (proposalStatus === 'succeeded') {
        const orderedProposals = proposals
            .slice()
            .sort((a, b) => a.proposalName.localeCompare(b.proposalName))
        content =<MemoizedProposalDataGrid proposals={orderedProposals}/>
    } else if (proposalStatus === 'failed') {
        content = <div>{error}</div>
    }

    return (
        <section className="proposal__container">
            <h2>Proposals</h2>
            {content}
        </section>
    )
}

