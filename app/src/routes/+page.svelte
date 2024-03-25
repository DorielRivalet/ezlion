<script lang="ts">
	import { page } from '$app/stores';
	import Logo from '$lib/components/Logo.svelte';
	import image from '$lib/assets/ezlion.png';
	import {
		authorName,
		authorUrl,
		description,
		projectGitHub,
		projectName,
		website
	} from '$lib/constants';
	import Footer from './Footer.svelte';
	import SectionHeadingTopLevel from '$lib/components/SectionHeadingTopLevel.svelte';
	import SectionHeading from '$lib/components/SectionHeading.svelte';
	import Link from 'carbon-components-svelte/src/Link/Link.svelte';
	import RepositoryThumbnail from '$lib/assets/ezlion.png';
	import './styles.css';

	const title = 'EZlion';
	const url = $page.url.toString();
</script>

<svelte:head>
	<link rel="canonical" href={url} />

	<!-- HTML Meta Tags -->
	<title>{title}</title>
	<meta name="title" content={title} />
	<meta name="description" content={description} />

	{#if authorName}
		<meta name="author" content={authorName} />
	{/if}

	<!-- Google / Search Engine Tags -->
	{#if image}
		<meta itemprop="name" content={title} />
		<meta itemprop="description" content={description} />
		<meta itemprop="image" content={image} />
	{/if}

	<!-- Facebook Meta Tags -->
	{#if image}
		<meta property="og:url" content={url} />
		<meta property="og:type" content="website" />
		<meta property="og:title" content={title} />
		<meta property="og:description" content={description} />
		<meta property="og:image" content={image} />
		<meta property="og:image:alt" content="Elzelion wearing sunglasses" />
		<meta property="og:site_name" content={projectName} />
	{/if}

	<!-- Discord-->
	<meta content="#89b4fa" data-react-helmet="true" name="theme-color" />

	<!-- Twitter Meta Tags -->
	{#if image}
		<meta name="twitter:card" content="summary_large_image" />
		{#if website}
			<meta property="twitter:domain" content={website} />
		{/if}
		<meta property="twitter:url" content={url} />
		<meta name="twitter:title" content={title} />
		<meta name="twitter:description" content={description} />
		<meta name="twitter:image" content={image} />
	{/if}
</svelte:head>

<div class="app">
	<main>
		<SectionHeadingTopLevel title={'EZlion'} />
		<Logo />
		<p class="slogan">Data retrieval, made easy</p>
		<section>
			<SectionHeading level={2} title={'API Reference'} withSeparator={true} />
			<p>See <Link data-sveltekit-reload href="./docs">here</Link> for the API reference</p>
			<Link aria-label="GitHub repository" href={projectGitHub}>
				<img src={RepositoryThumbnail} alt="Repository thumbnail" />
			</Link>
		</section>
	</main>
	<Footer />
</div>

<style type="text/css">
	.slogan {
		font-style: italic;
	}

	.app {
		display: flex;
		flex-direction: column;
		background-color: var(--ctp-mantle);
	}

	main {
		position: relative;
		flex: 1;
		display: flex;
		flex-direction: column;
		padding: var(--cds-spacing-08);
		width: 100%;
		max-width: 100vw;
		margin: 0 auto;
		box-sizing: border-box;
		min-height: 90vh;
		background-color: var(--ctp-base);
		border-left: var(--cds-spacing-01) solid var(--ctp-surface0);
		border-right: var(--cds-spacing-01) solid var(--ctp-surface0);
		border-bottom: var(--cds-spacing-01) solid var(--ctp-surface0);
		border-radius: 0px 0px 10px 10px;
	}
</style>
