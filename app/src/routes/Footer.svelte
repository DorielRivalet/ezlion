<!--
  ~ © 2023 Doriel Rivalet
  ~ Use of this source code is governed by a MIT license that can be
  ~ found in the LICENSE file.
-->

<script lang="ts">
	import LogoGithub from 'carbon-icons-svelte/lib/LogoGithub.svelte';
	import * as constant from '$lib/constants';
	import Link from 'carbon-components-svelte/src/Link/Link.svelte';
</script>

<footer>
	<div class="subtle item-container">
		<div>Created on {constant.datePublished}</div>
	</div>

	<div class="item-container">
		<Link href={constant.authorUrl}>{constant.authorName} &copy {new Date().getUTCFullYear()}</Link>
		<div>
			Powered by <Link href="https://kit.svelte.dev/docs/introduction">SvelteKit</Link>
		</div>
	</div>

	<div class="item-container">
		<Link aria-label="GitHub repository" href={constant.projectGitHub}>
			<LogoGithub size={32} />
		</Link>
		<div class="subtle">v{constant.appVersion}</div>
	</div>
</footer>

<style lang="css">
	.item-container {
		display: flex;
		flex-direction: column;
		gap: 1rem;
		align-items: center;
	}

	footer {
		padding: var(--cds-spacing-07);
		background-color: var(--ctp-crust);
		display: flex;
		justify-content: space-between;
		align-items: center;
	}
</style>
