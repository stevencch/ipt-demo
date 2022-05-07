import React from "react";
import { Proposal } from "../../types/proposals/Proposal";

export const ProposalView: React.FC<{ proposal:Proposal }> = ({ proposal }) => {
    return (
        <article>
            <div>{proposal.proposalName}</div>
        </article>
    )
}

export const MemoizedVaccinationView = React.memo(ProposalView);